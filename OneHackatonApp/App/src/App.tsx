import React from "react";
import "./App.css";
import MainPage from "./Pages/MainPage/MainPage";
import AppLogic from "./AppLogic";

export interface IPresent {
  value: number;
  content: string;
}

export const PresentContext = React.createContext<IPresent[]>([]);

function App() {

  const { checkIfRouteIsAuthenticated } = AppLogic();


  return <MainPage />;
}

export default App;
