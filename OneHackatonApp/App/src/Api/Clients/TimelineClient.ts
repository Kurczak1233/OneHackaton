import application from "../../appConfig.json";
import { AxiosClient } from "../AxiosClient/AxiosClient";

const base = application.baseUrl;
const TimeLine = "TimeLine";

const getTimelineData = async (): Promise<any> => {
  return AxiosClient("GET", `${TimeLine}`, base);
};

export { getTimelineData };
