import React,{Component} from "react";
 export default class Login extends Component{

 
render(){
    return(

    <div className="container" style={{width:"300Px" ,border:"10px"}}>
 <div className="row">
       <label htmlFor="Username">Username</label>
       </div>
       <div className="row">
       <input type="text" id="Username" name="Username" placeholder="User name.." />
   </div> 
   <div className="row">
       <label htmlFor="Password">Password</label>
       </div>
       <div className="row">
       <input type="Password" id="Password" name="Password" placeholder="Password.." />
   </div> 
   <br/>
   <div className="row">
     <button className="submit" onClick={()=>{this.LoginAuth(document.getElementById("Username").value,document.getElementById("Password").value)}}>Login</button>
   </div> 
        </div>
    );




}
LoginAuth(username,password){
    if(username=="admin" & password=="admin")
    {
        document.cookie="isAthuntication=true"
    window.location.href="/";
    }  else
    {
        document.cookie="isAthuntication=false"

        document.getElementById("Username").value="";
        document.getElementById("Password").value=""
    }
    
    }

}