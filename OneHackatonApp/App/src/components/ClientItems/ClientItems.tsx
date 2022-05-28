import styles from "./ClientItems.module.scss";

interface IClientItems {
  usersItems: { name: string }[];
}

const ClientItems = ({ usersItems }: IClientItems) => {
  return (
    <div className={styles.sidesItems}>
      {usersItems.map((item, index) => (
        <div key={`${item.name} ${index}`} className={styles.item}>
          <div className={styles.extensionBar} />
          <div className={styles.note}>{item.name}</div>
        </div>
      ))}
    </div>
  );
};

export default ClientItems;
