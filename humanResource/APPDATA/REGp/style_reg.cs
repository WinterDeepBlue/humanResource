.box input
{
    padding: 10px 0;
    margin-bottom: 30px;
    color: #757CD5
}
.box textarea
{
    height: 80px;
    padding: 10px;
    margin-bottom: 40px;
}
.box input,
.box textarea{
    width: 100%;
    box-sizing: border-box;
    box-shadow: none;
    outline: none;
    border: none;
    color:#757CD5;
    border-bottom: 1px solid #999;
}
.box textarea 
{
    margin-bottom: 30px;
    color:#999;
}
.box input[type="submit"] 
{
    border-bottom: none;
    cursor: pointer;
    color: #fff;
    margin-bottom: 0px;
    text-transform: uppercase;
    border: none;
}
.box form div 
{
    position: relative;
}
.box form div label 
{
    position: absolute;
    top: 10px;
    color: #999;     
    transition: .5s;
    pointer-events: none;
}
.box input:focus ~ label,
.box textarea:focus ~ label,
.box input:valid ~ label
{
    top: -12px;
    left: 0px;
    font-size: 14px;
    font-weight: bold;
}
.box textarea label 
{
    top: -12px;
    left: 0px;
    color: #999;
    font-size: 14px;
    font-weight: bold;
}