import { useCallback, useEffect, useState } from "react";
import { useAuth0 } from "@auth0/auth0-react";
import axios from "axios";

const AppLogic = () => {
    const [isAccessTokenSet, setIsAccessTokenSet] = useState<boolean>(false);
    const { getAccessTokenSilently, logout, isAuthenticated } = useAuth0();

    const setAxiosInterceptor = useCallback(
        (accessToken: string) => {
          axios.interceptors.request.use(
            (config) => {
              if (config && config.headers) {
                config.headers["Authorization"] = `Bearer ${accessToken}`;
              }
              return config;
            },
              logout());
        },
        [logout]
      );
    
      const getAccessTokenAndSetAxiosInterceptors = useCallback(async () => {
        const accessToken = await getAccessTokenSilently();
        if (accessToken !== "") {
          setAxiosInterceptor(accessToken);
          setIsAccessTokenSet(true);
        }
      }, [getAccessTokenSilently, setAxiosInterceptor]);
    
      const checkIfRouteIsAuthenticated = (component: JSX.Element) => {
        return !isAccessTokenSet ? (
          <div />
        ) : isAuthenticated ? (
          component
        ) : (
          <NoAccessComponent />
        );
      };
    
      useEffect(() => {
        if (!isAccessTokenSet && isAuthenticated)
          getAccessTokenAndSetAxiosInterceptors();
      }, [
        getAccessTokenAndSetAxiosInterceptors,
        isAccessTokenSet,
        isAuthenticated,
      ]);
    
      return { checkIfRouteIsAuthenticated };
    };
    
    export default AppLogic;