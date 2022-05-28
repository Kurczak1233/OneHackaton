import Textarea from "../../commonComponents/textarea/Textarea";
import UserCreatentials from "../../commonComponents/UserCreatentials/UserCredentials";
import styles from "./DevelopersNewReport.module.scss";
import DevelopersNewReportLogic from "./DevelopersNewReportLogic";

const DevelopersNewReports = () => {
  const {
    description,
    setDescription,
    email,
    setEmail,
    creadentials,
    setCredentials,
    submitData,
  } = DevelopersNewReportLogic();

  return (
    <div className={styles.wrapper}>
      <div className={styles.upperPart}>
        <div className={styles.textWrapper}>Developers</div>
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
            title={"Send report"}
            credentialsValue={creadentials}
            setCredentialsValue={setCredentials}
            emailValue={email}
            color={"#e3005f"}
            setEmailValue={setEmail}          />
          <div className={styles.submitButton} onClick={submitData}>
            Send
          </div>
        </div>
      </div>
    </div>
  );
};

export default DevelopersNewReports;
