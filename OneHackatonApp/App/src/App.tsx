import React from "react";
import "./App.css";
import MainPage from "./Pages/MainPage/MainPage";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import DevelopersChooseItemPage from "./Pages/DevelopersChooseItemPage/DevelopersChooseItemPage";
import DevelopersNewReports from "./Pages/DevelopersNewReport/DevelopersNewReport";
import ClientsNewReports from "./Pages/ClientsNewReport/ClientsNewReport";
import ClientsChooseItemPage from "./Pages/ClientsChooseItemPage/ClientsChooseItemPage";

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
        <Route
          path="/developers-note/new/report"
          element={<DevelopersNewReports />}
        />
        <Route path={"clients-note/new"} element={<ClientsChooseItemPage />} />
        <Route
          path="/clients-note/new/report"
          element={<ClientsNewReports />}
        />
      </Routes>
    </Router>
  );
}

export default App;
