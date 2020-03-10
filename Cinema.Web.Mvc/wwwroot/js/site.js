// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

jQuery(document).ready(function () {

    //setup format for the date picker
    var options = {
        format: 'dd.mm.yyyy',
        todayHighlight: true,
        autoclose: true,
    };
    jQuery("#ScreeningDate").datepicker(options);

    //function for setting up date properly and returning it
    $.date = function (dateObject) {
        var d = new Date(dateObject);
        var day = d.getDate();
        var month = d.getMonth() + 1;
        var year = d.getFullYear();
        if (day < 10) {
            day = "0" + day;
        }
        if (month < 10) {
            month = "0" + month;
        }
        var date = day + "/" + month + "/" + year;

        return date;
    };

    //create map based on the data on the #seat-map div
    var seatMap = $('#seat-map');

    var seatColumns = seatMap.data("columns");
    var seatRows = seatMap.data("rows");
    var seatsReserved = seatMap.data("reserved-seats");
    var ticketCat = seatMap.data("ticket-cat");
    var ticketPrice = seatMap.data("ticket-price");
    var seatMap = [];

    // repeat :: Int -> String -> String
    const repeat = (n, s) =>
        concat(replicate(n, s));

    // GENERIC FUNCTIONS ------------------------------------------------------

    // concat :: [[a]] -> [a] | [String] -> String
    const concat = xs =>
        xs.length > 0 ? (() => {
            const unit = typeof xs[0] === 'string' ? '' : [];
            return unit.concat.apply(unit, xs);
        })() : [];

    // replicate :: Int -> a -> [a]
    const replicate = (n, x) =>
        Array.from({
            length: n
        }, () => x);

    for (i = 0; i < seatRows; i++) {
        seatMap.push(repeat(seatColumns, "a"));
    }
    console.log(seatMap);
    console.log(seatsReserved.split(","));

    var $cart = $('#selected-seats'),
        $counter = $('#counter'),
        $total = $('#total');

    var firstSeatLabel = 1;

    var sc = $('#seat-map').seatCharts({
        map: seatMap,
        seats: {
            a: {
                price: parseInt(ticketPrice),
                classes: 'seat', //your custom CSS class
                category: ticketCat
            }

        },
        naming: {
            top: false,
            getLabel: function (character, row, column) {
                return firstSeatLabel++;
            },
        },
        click: function () {
            if (this.status() == 'available') {

                //create a new <li> which we'll add to the cart items
                $('<li>' + this.data().category + ' Seat # ' + this.settings.label + ': <b>$' + this.data().price + '</b> <a href="#" class="cancel-cart-item">[cancel]</a></li>')
                    .attr('id', 'cart-item-' + this.settings.id)
                    .data('seatId', this.settings.id)
                    .appendTo($cart);

                var reservedSeats = $("#SelectedSeatsString").val();
                if (reservedSeats.length == 0)
                    $("#SelectedSeatsString").val(this.settings.label);
                else
                    $("#SelectedSeatsString").val(reservedSeats + "," + this.settings.label);

                /*
                 * Lets update the counter and total
                 *
                 * .find function will not find the current seat, because it will change its status only after return
                 * 'selected'. This is why we have to add 1 to the length and the current seat price to the total.
                 */

                $counter.text(sc.find('selected').length + 1);
                $total.text(recalculateTotal(sc) + this.data().price);
                return 'selected';

            } else if (this.status() == 'selected') {

                var reservedSeats = $("#SelectedSeatsString").val();

                if (reservedSeats.lastIndexOf(",") == -1) {
                    $("#SelectedSeatsString").val(reservedSeats.replace(this.settings.label, ""));
                } else {
                    if (reservedSeats.indexOf(this.settings.label) == 0) {
                        $("#SelectedSeatsString").val(reservedSeats.replace(this.settings.label + ",", ""));
                    } else {
                        $("#SelectedSeatsString").val(reservedSeats.replace("," + this.settings.label, ""));
                    }
                }

                //update the counter
                $counter.text(sc.find('selected').length - 1);
                //and total
                $total.text(recalculateTotal(sc) - this.data().price);

                //remove the item from our cart
                $('#cart-item-' + this.settings.id).remove();
                //seat has been vacated
                return 'available';

            } else if (this.status() == 'unavailable') {
                //seat has been already booked
                return 'unavailable';

            } else {
                return this.style();
            }
        }
    });

    //this will handle "[cancel]" link
    $('#selected-seats').on('click', '.cancel-cart-item', function (e) {
        //let's just trigger Click event on the appropriate seat, so we don't have to repeat the logic here
        e.preventDefault();
        sc.get($(this).parents('li:first').data('seatId')).click();
    });

    function recalculateTotal(sc) {
        var total = 0;

        //find every selected seat and sum its price
        sc.find('selected').each(function () {
            total += this.data().price;
        });

        return total;
    }

    //disable reserved seats
    sc.status(seatsReserved.split(","), 'unavailable'); //set status for two seats
});