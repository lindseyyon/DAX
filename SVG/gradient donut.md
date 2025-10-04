Female_Donut = 
VAR Donut_Fill = ([COUNT_female]/[COUNT_gender])*100
VAR Donut_Text = FORMAT(Donut_Fill/100,"#.0%")
VAR Circumference = 2 * PI() * 80
VAR Fill_Length = (Circumference*Donut_Fill)/100
VAR Gap_Length = Circumference-Fill_Length
VAR SVG_Data_URL = "data:image/svg+xml;utf8,"
VAR SVG_Start = "<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 250 250'>"
VAR SVG_Data = 
"
<defs>
    <linearGradient id='gradient' x1='0%' y1='0%' x2='100%' y2='0%'>
        <stop offset='0%' style='stop-color: #3c4cad' />
        <stop offset='100%' style='stop-color: #f04393' />
    </linearGradient>
<style>
    #backgroundCircle {
        fill: none;
        stroke: #f7f3f3;
        stroke-width: 15;
    }
    #fillCircle {
        fill: none;
        stroke: url(#gradient);
        stroke-width: 15;
        stroke-dasharray: "& Fill_Length &" , "& Gap_Length &";
        transform: rotate(-90deg);
        transform-origin: center;
        stroke-linecap: round;
    }
    #text {
        font-family: Segoe UI;
        font-size: 1.5em;
        text-anchor: middle;
        fill: #666;
    }
</style>
</defs>

<circle id='backgroundCircle' cx='125' cy='125' r='80' />
<circle id='fillCircle' cx='125' cy='125' r='80' />
<text id='text' x='100' y='100' dx='1.1em' dy='1.2em'> "& Donut_Text &" </text>
"
VAR SVG_End = "</svg>"
RETURN
SVG_Data_URL & SVG_Start & SVG_Data & SVG_End
