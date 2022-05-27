import React from "react";
import "./App.css";
import MainPage from "./Pages/MainPage/MainPage";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import DevelopersChooseItemPage from "./Pages/DevelopersChooseItemPage/DevelopersChooseItemPage";

export interface IPresent {
  value: number;
  content: string;
}

export const PresentContext = React.createContext<IPresent[]>([]);

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<MainPage />} />
        <Route
          path="/developers-note/new"
          element={<DevelopersChooseItemPage />}
        />
      </Routes>
    </Router>
  );
}

export default App;
