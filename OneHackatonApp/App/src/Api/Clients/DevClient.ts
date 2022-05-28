import application from "../../appConfig.json";
import { AxiosClient } from "../AxiosClient/AxiosClient";

const base = application.baseUrl;
const Dev = "Dev";

export interface ICreateDevNoteRequest {
  credentials: string;
  description: string;
  email: string;
}

const createDevNote = async (body: ICreateDevNoteRequest): Promise<any> => {
  return AxiosClient("POST", `api/${Dev}`, base, { body });
};

export { createDevNote };
