import application from "../../appConfig.json";
import { AxiosClient } from "../AxiosClient/AxiosClient";

const base = application.baseUrl;
const Client = "Client";

export interface ICreateClientNoteRequest {
  credentials: string;
  description: string;
  email: string;
}

const createClientNote = async (
  body: ICreateClientNoteRequest
): Promise<any> => {
  return AxiosClient("POST", `${Client}`, base, { body });
};

export { createClientNote };
