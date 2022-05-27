import React from "react";
import "./App.css";
import MainPage from "./Pages/MainPage/MainPage";

export interface IPresent {
  value: number;
  content: string;
}

export const PresentContext = React.createContext<IPresent[]>([]);

function App() {
  return <MainPage />;
}

export default App;
