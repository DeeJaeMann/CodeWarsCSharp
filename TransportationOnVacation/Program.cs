// After a hard quarter in the office you decide to get some rest on a vacation. So you will book a flight for you and 
// your girlfriend and try to leave all the mess behind you.
//
//     You will need a rental car in order for you to get around in your vacation. The manager of the car rental makes 
//     you some good offers.
//
//     Every day you rent the car costs $40. If you rent the car for 7 or more days, you get $50 off your total. 
//     Alternatively, if you rent the car for 3 or more days, you get $20 off your total.
//
//     Write a code that gives out the total amount for different days(d).

static int RentalCarCost(int d)
{
    // base cost per day 40
    // 7 or more - 50 total
    // 3 or more - 20 total
    int baseCost = 40;
    int weekDiscount = 50; 
    int threeDiscount = 20;

    int result = d * baseCost;
    if (d >= 7) result -= weekDiscount;
    else if (d >= 3) result -= threeDiscount;
    return result;
}