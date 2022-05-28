import styles from "./Textarea.module.scss";

interface ITextarea {
  label: string;
  setValue: React.Dispatch<React.SetStateAction<string>>;
  value: string;
}

const Textarea = ({ label, setValue, value }: ITextarea) => {
  return (
    <div className={styles.textareaWrapper}>
      <div className={styles.label}>{label}</div>
      <textarea
        className={styles.textarea}
        value={value}
        onChange={(e) => setValue(e.target.value)}
        placeholder={"Type description..."}
      />
    </div>
  );
};

export default Textarea;
