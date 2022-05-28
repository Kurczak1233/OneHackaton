import styles from "./input.module.scss";

interface IInput {
  label: string;
  setValue: React.Dispatch<React.SetStateAction<string>>;
  value: string;
}

const Input = ({ value, setValue, label }: IInput) => {
  return (
    <div className={styles.inputWrapper}>
      <div className={styles.label}>{label}</div>
      <input
        className={styles.inputs}
        value={value}
        onChange={(e) => setValue(e.target.value)}
      />
    </div>
  );
};

export default Input;
