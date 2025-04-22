using Bridge.ClothingFormatters;
using Bridge.ClothingItems;
using Bridge.ClothingViews;

var shoe = new Shoe("Nike", 10.5, "Red", true, "Mesh");
var dress = new Dress("S", "Black", "Cocktail", "Silk");

var shoeFormatter = new ShoeClothingFormatter(shoe);
var dressFormatter = new DressClothingFormatter(dress);

var detailedShoeView = new DetailedClothingView(shoeFormatter);
var compactShoeView = new CompactClothingView(shoeFormatter);
var compactDressView = new CompactClothingView(dressFormatter);
var miniDressView = new MiniClothingView(dressFormatter);

detailedShoeView.Display();
compactShoeView.Display();
compactDressView.Display();
miniDressView.Display();
