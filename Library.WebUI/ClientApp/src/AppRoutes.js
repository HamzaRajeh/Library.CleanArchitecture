import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
 import Login from "./components/Login/Login";
 import MangeRent from "./components/Library/ManagBook"
const AppRoutes = [
  {
    index: true,
    element: <Home />
  }
 ,
  {
    path: '/fetch-data',
    element: <FetchData />
  },
  {
    path: '/ManagBook',
    element: <MangeRent />
  },
  {
    path: '/Login',
    element: <Login/>
  }
];

export default AppRoutes;
