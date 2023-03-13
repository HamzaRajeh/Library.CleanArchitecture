import React,{Component} from 'react';
import '../styles/Popup.css';

import $ from 'jquery';
function Popup( {TitelBook}){

    




     return(

         <div className="form-popup" id="myForm">
  <form  className="form-container">
    <h5>Rent {TitelBook}</h5>
     <input type="text" placeholder="  fullname " name="fullname" required/>
     <input type="text" placeholder="  PhoneNumber " name="PhoneNumber" required/>
    <button type="button" className="btn" >Confirm</button>
    <button type="button" className="btn cancel" onClick={()=>{  $("#myForm").hide()}}>Close</button>
   
</form>
</div>
        
     );

    

    
     
}

export default Popup;
