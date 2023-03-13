 import React, { useEffect, useState } from "react";
 
 function MangeRent()
 {
    const [rents,setrents]=new useState([])

useEffect(()=>{

    fetch('/api/rent', {
        method: 'GET',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        } 
      })
      .then(function (response) {
        setrents(response.json());
      }) 
      .catch (function (error) {
        console.log('Request failed', error);
      });
},[])

return(
    <>
    <table>
<thead>
<th>Book name</th><th>Customer's name</th><th>Phone number</th><th>Rerent Date</th> <th>Rerent Date</th> <th>recive Date</th> <th>Price Late</th>

</thead>
<tbody>

    {
rents.map(
    rent=>{
        return(
            <>           
             <td>{rent.bookId}</td>
             <td>{rent.fullName}</td>
             <td>{rent.phoneNumber}</td>
             <td>{rent.reRentDate}</td>
             <td>{rent.reciveDate}</td>
             <td>0</td>
           
            
            </>

            )
    }
)
    }



</tbody>
    </table>
    </>
);



 }
 export default MangeRent;