import { useState } from "react";
import {
  createClientNote,
  ICreateClientNoteRequest,
} from "../../Api/Clients/ClientClient";

const ClientsNewReportLogic = () => {
  const [description, setDescription] = useState<string>("");
  const [email, setEmail] = useState<string>("");
  const [creadentials, setCredentials] = useState<string>("");
  const [date, setDate] = useState<string>("");
  const submitData = async () => {
    const request: ICreateClientNoteRequest = {
      credentials: creadentials,
      description: description,
      email: email,
      date: new Date(date),
    };
    await createClientNote(request);
  };
  return {
    description,
    setDescription,
    email,
    setEmail,
    creadentials,
    setCredentials,
    submitData,
    setDate,
    date,
  };
};

export default ClientsNewReportLogic;
