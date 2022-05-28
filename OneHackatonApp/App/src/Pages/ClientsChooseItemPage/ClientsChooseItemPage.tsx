import { Link } from "react-router-dom";
import styles from "./ClientsChooseItemPage.module.scss";

const ClientsChooseItemPage = () => {
  return (
    <div className={styles.wrapper}>
      <div className={styles.heading}>
        <div className={styles.title}>Clients/Testers</div>
        <div className={styles.titleUnderlineBar} />
      </div>
      <div className={styles.buttonsWrapper}>
        <Link className={styles.link} to={"/clients-note/new/report"}>
          <div className={styles.buttonItem}>Send Raport</div>
        </Link>
        <div className={styles.buttonItem}>Send Bug Fix</div>
        <div className={styles.buttonItem}>Send App Update</div>
        <div></div>
      </div>
    </div>
  );
};

export default ClientsChooseItemPage;
