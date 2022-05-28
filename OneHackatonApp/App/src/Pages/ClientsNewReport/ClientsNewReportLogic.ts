import { useState } from "react";
import {
  createClientNote,
  ICreateClientNoteRequest,
} from "../../Api/Clients/ClientClient";

const ClientsNewReportLogic = () => {
  const [description, setDescription] = useState<string>("");
  const [email, setEmail] = useState<string>("");
  const [creadentials, setCredentials] = useState<string>("");
  const submitData = async () => {
    const request: ICreateClientNoteRequest = {
      credentials: creadentials,
      description: description,
      email: email,
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
  };
};

export default ClientsNewReportLogic;
