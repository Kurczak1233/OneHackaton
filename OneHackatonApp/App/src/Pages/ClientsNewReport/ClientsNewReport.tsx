import Textarea from "../../commonComponents/textarea/Textarea";
import UserCreatentials from "../../commonComponents/UserCreatentials/UserCredentials";
import ClientsNewReportLogic from "./ClientsNewReportLogic";
import styles from "./ClientsNewReport.module.scss";

const ClientsNewReports = () => {
  const {
    description,
    setDescription,
    email,
    setEmail,
    creadentials,
    setCredentials,
    submitData,
  } = ClientsNewReportLogic();

  return (
    <div className={styles.wrapper}>
      <div className={styles.upperPart}>
        <div className={styles.textWrapper}>Clients/Testers</div>
      </div>
      <div className={styles.mainComponent}>
        <div className={styles.leftPartOfMainComponent}>
          <div className={styles.title}>Leave a message</div>
          <Textarea
            value={description}
            setValue={setDescription}
            label={"Description"}
          />
        </div>
        <div className={styles.rightPartOfMainComponent}>
          <UserCreatentials
            title={"Request a feature"}
            credentialsValue={creadentials}
            setCredentialsValue={setCredentials}
            emailValue={email}
            color={"#0471a6"}
            setEmailValue={setEmail}
          />
          <div className={styles.submitButton} onClick={submitData}>
            Send
          </div>
        </div>
      </div>
    </div>
  );
};

export default ClientsNewReports;
