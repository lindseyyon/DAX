Status = 

var color = switch(true(),
    [Percentage Complete] < .5, "#EB895F",
    "#9071CE")

var start_String = "data:image/svg+xml;utf81,"
var svg_full =  "<svg width='500' height='200' viewBox='0 10 750 100' fill='none' xmlns='http://www.w3.org/2000/svg'>
<rect x='30' y='32' width='"& 660 * [Percentage Complete] &"' height='80' rx='5' fill='"& color &"'/>
<rect x='5' y='10' width='710' height='130' rx='10' stroke='#777171' stroke-width='10'/>
</svg>"


return start_String & svg_full
