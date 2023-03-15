 import React, { Component, useEffect, useState } from "react";
 
 export default class MangeRent extends Component
 {
    Getday(rentDate,reciveDate){

        var date1 = new Date(rentDate);
        var date2 = new Date(reciveDate);
          
        // To calculate the time difference of two dates
        var Difference_In_Time = date2.getTime() - date1.getTime();
          
        // To calculate the no. of days between two dates
        var Difference_In_Days = Difference_In_Time / (1000 * 3600 * 24);
          
        //To display the final no. of days (result)
        console.log("Total number of days between dates  <br>"
                   + date1 + "<br> and <br>" 
                   + date2 + " is: <br> " 
                   + Difference_In_Days);
                   return Difference_In_Days;
      }   
constructor(props)
{
    let isAthuntication = document.cookie;
    if (isAthuntication==false){
      window.location.href="/Login";
    }  else{
    

    super(props)
    this.state={rents:[]}
}
}


componentDidMount() {
    this.populateData();
  }
  async populateData() {
    const response = await fetch('api/Rent');
    const data = await response.json();
    this.setState({ rents: data });
  }
 render(){

return(
   
    <div>

    <table className="table table-striped" aria-labelledby="tableLabel"> 
 <thead>
    <tr>
                        <th>Book name</th><th>Customer's name</th><th>Phone number</th><th>from Date</th>   <th>Recive Date</th><th>Priod Type</th> <th>Rent For </th>   <th>Status</th>  <th> Recive Book </th>
    </tr>
 </thead>


 
<tbody>

    {   
this.state.rents.map(
    rent=>{
        return(
            <>    
              <tr key={rent.id}>       
             <td>{rent.bookName}</td>
             <td>{rent.fullName}</td>
             <td>{rent.phoneNumber}</td>
             <td>{rent.rentDate}</td>
               <td>{rent.reciveDate}</td>
              <td>{rent.priodName}</td>
              <td>{rent.reRent +' '+rent.priodName}</td>
               
              <td>{rent.statuName}</td>
             <td><button className="btn btn-success" onClick={ async()=>{

                        const putMethod = {
                            method: 'PUT', // Method itself
                            headers: {
                                'Content-type': 'application/json; charset=UTF-8' // Indicates the content 
                            } // We send data in JSON format
                        }

                        // make the HTTP put request using fetch api
                        fetch('/api/Rent/' + rent.id, putMethod)
                            .then(response => response.json())
                            .then(data => console.log(data)
                           

                        ) // Manipulate the data retrieved back, if we want to do something with it
                            .catch(err => console.log(err))

             }}>Recive
                </button></td>
                </tr>
            </>

            )
    }
)
      }



</tbody>
    </table>
    </div>

       
);
    


 }}
 