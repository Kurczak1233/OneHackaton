import Input from "../input/input";
import styles from "./UserCredentials.module.scss";

interface IUserCreatentials {
  title: string;
  color: string;
  credentialsValue: string;
  setCredentialsValue: React.Dispatch<React.SetStateAction<string>>;
  emailValue: string;
  setEmailValue: React.Dispatch<React.SetStateAction<string>>;
}

const UserCreatentials = ({
  title,
  color,
  credentialsValue,
  setCredentialsValue,
  emailValue,
  setEmailValue,
}: IUserCreatentials) => {
  return (
    <div className={styles.wrapper}>
      <div className={styles.title} style={{ color: color }}>
        {title}
      </div>
      <Input
        label={"Credentials"}
        setValue={setCredentialsValue}
        value={credentialsValue}
      />
      <Input label={"Email"} setValue={setEmailValue} value={emailValue} />
    </div>
  );
};
export default UserCreatentials;
