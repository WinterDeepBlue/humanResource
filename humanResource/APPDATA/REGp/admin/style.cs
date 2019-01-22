body {
    background:url(background.png);
    font-family:'PT Sans',Helvetica, Arial, sans-serif;
    color:#fff;
       background-repeat: no-repeat;
       background-size:cover;
    }
    
    .page-container {
    margin: 120px auto 0 auto;
    }
    
    h1 {
        font-size: 500%;
        font-weight: 70;
        text-shadow:0 1px 4px rgba(0,0,0,.2);
        text-align:center;
        color: black;
    }

    h3 {
        font-size: 200%;
        font-weight: 70;
        text-shadow:0 1px 4px rgba(0,0,0,.2);
        text-align:center;
        color: black;
        padding-bottom: 10px
    }
    
    form {
    position:relative;
    width:305px;
    margin:15px auto 0 auto;
    text-align:center;
    
    }
    
    input {
    width:100%;
    height:42px;
    margin-top:25px;
    padding:0 15px;
    background:#2d2d2d;
    background:rgba(40,40,40,.1);
    -moz-border-radius: 6px;
    -webkit-border-radius:6px;
/*    text-align:center;*/
    border-radius:6px;
    border:1px solid #3d3d3d;
    border:1px solid rgba(255,255,255,.15);
    -moz-box-shadow:0 2px 3px 0 rgba(0,0,0,.1) inset;
    -webkit-box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    box-shadow: 0 2px 3px 0 rgba(0,0,0,.1) inset;
    font-family: 'PT Sans', Helvetica, Arial, sans-serif;
    font-size:16px;
    color: black;
    text-shadow:0 1px 2px rgba(0,0,0,.1);
    -o-transition: all .2s;
    -moz-transition: all .2s;
    -webkit-transition: all .2s;
    -ms-transition: all .2s;
    }
    
    input:-moz-placeholder { color: #fff; }
    input:-ms-input-placeholder { color: #fff; }
    input::-webkit-input-placeholder { color: #fff; }
    
    input:focus {
    outline:none;
    -moz-box-shadow:
            0 2px 3px 0 rgba(0,0,0,.1) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
    -webkit-box-shadow:
            0 2px 3px 0 rgba(0,0,0,.1) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
    box-shadow:
            0 2px 3px 0 rgba(0,0,0,.1) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
    }
    
    button {
    cursor:pointer;
    width:100%;
    height:44px;
    margin-top:25px;
    padding:0;
    -moz-border-radius: 6px;
    -webkit-border-radius: 6px;
    border-radius: 6px;
    font-family:'PT Sans', Helvetica, Arial, sans-serif;
    font-size:14px;
    font-weight:700;
    color:#fff;
    text-shadow:0 1px 2px rgba(0,0,0,.1);
    -o-transition: all .2s;
        -moz-transition: all .2s;
        -webkit-transition: all .2s;
        -ms-transition: all .2s;
    }
    
    button:hover {
        -moz-box-shadow:
            0 15px 30px 0 rgba(255,255,255,.15) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
        -webkit-box-shadow:
            0 15px 30px 0 rgba(255,255,255,.15) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
        box-shadow:
            0 15px 30px 0 rgba(255,255,255,.15) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
    }
    
    button:active {
        -moz-box-shadow:
            0 15px 30px 0 rgba(255,255,255,.15) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
        -webkit-box-shadow:
            0 15px 30px 0 rgba(255,255,255,.15) inset,
            0 2px 7px 0 rgba(0,0,0,.2);
        box-shadow:        
            0 5px 8px 0 rgba(0,0,0,.1) inset,
            0 1px 4px 0 rgba(0,0,0,.1);
    
        border: 0px solid #ef4300;
    }

#grad {
    height: 44px;
    background-image: linear-gradient(to right, #ff6dab, #bb45da, #a236ec, #4e13f1); /* Standard syntax (must be last) */
}

hr {
   border: 0;
   height: 4px;
   background: #a60000;
   background-image: -webkit-linear-gradient(left, #ffb366, #ff6dab, #a236ec); 
   background-image:    -moz-linear-gradient(left, #B2B2B2, #a60000, #B2B2B2); 
   background-image:     -ms-linear-gradient(left, #B2B2B2, #a60000, #B2B2B2); 
   background-image:      -o-linear-gradient(left, #B2B2B2, #a60000, #B2B2B2); 
}

.btn-primary{
    border-color: white
}