import { useState } from "react";
import { useNavigate } from "react-router-dom";
import {
  createDevNote,
  ICreateDevNoteRequest,
} from "../../Api/Clients/DevClient";

const DevelopersNewReportLogic = () => {
  const [description, setDescription] = useState<string>("");
  const [email, setEmail] = useState<string>("");
  const [creadentials, setCredentials] = useState<string>("");
  const [date, setDate] = useState<string>("");
  const navigate = useNavigate();
  const submitData = async () => {
    const request: ICreateDevNoteRequest = {
      credentials: creadentials,
      description: description,
      email: email,
      date: new Date(date),
    };
    await createDevNote(request);
    navigate(-2);
  };
  return {
    description,
    setDescription,
    email,
    setEmail,
    creadentials,
    setCredentials,
    submitData,
    date,
    setDate,
  };
};

export default DevelopersNewReportLogic;
