import React from "react";
import Popup from "./popup";
import $ from 'jquery';
 function  CBook({id,Titel})
{
    return (<>
  <div className="card" >
    <h5 className="title">{Titel}</h5>
    <div id={"card-info"+id}>
    <button className="btn-circle" onClick={()=>{
      $("#card-info"+id).hide();
      $("#formRent"+id).show();

    }}>Rent</button>
    </div>
    <div id={"formRent"+id} style={{display:"none" ,marginTop:"70px"}}>
      <input id={"US"+id} placeholder="Fullname" type="text" required/>
       <input id={"NP"+id} placeholder="PhoneNumber" type="text" required/>
                <input id={"ReRent" + id} placeholder="Rent for" type="text" required />
 <div className="btn-form"   style={{display:"flex",flexDirection:"column" }}>
                    <button style={{ borderRadius: "20px" }} onClick={() => {

                        var bodyD = JSON.stringify({
                            bookId: id,
                            fullName: document.getElementById("US"+id).value,
                            phoneNumber: document.getElementById("NP" + id).value,
                            reRent:Number(document.getElementById("ReRent" + id).value)
                        });


                        fetch('/api/Rent', {
                            method: 'POST',
                            headers: {
                                'Accept': 'application/json, text/plain, */*',
                                'Content-Type': 'application/json'
                            },
                            body: bodyD
                        })
                            .then(function (response) {
                                return response.json();
                            })
                            .then(function (result) {
                                alert("seccess..");
                              })
                            .catch(function (error) {
                                console.log('Request failed', error);
                            });
                        this.state.proprties.recall();


                    }}>Confirm</button>
           <button  style={{borderRadius:"20px" 
}}   onClick={()=>{
      $("#formRent"+id).hide();
      $("#card-info"+id).show();
    }}>Back</button>
 </div>

     </div>

  </div>
    </>);
}

export default CBook;