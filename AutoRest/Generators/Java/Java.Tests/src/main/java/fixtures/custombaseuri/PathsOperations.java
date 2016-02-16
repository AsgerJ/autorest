/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.custombaseuri;

import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import fixtures.custombaseuri.models.ErrorException;
import java.io.IOException;
import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.Path;

/**
 * An instance of this class provides access to all the operations defined
 * in PathsOperations.
 */
public interface PathsOperations {
    /**
     * The interface defining all the services for PathsOperations to be
     * used by Retrofit to perform actually REST calls.
     */
    interface PathsService {
        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("customuri")
        Call<ResponseBody> getEmpty(@Path("accountName") String accountName, @Path("host") String host);

    }
    /**
     * Get a 200 to test a valid base uri.
     *
     * @param accountName Account Name
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the {@link ServiceResponse} object if successful.
     */
    ServiceResponse<Void> getEmpty(String accountName) throws ErrorException, IOException, IllegalArgumentException;

    /**
     * Get a 200 to test a valid base uri.
     *
     * @param accountName Account Name
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link Call} object
     */
    Call<ResponseBody> getEmptyAsync(String accountName, final ServiceCallback<Void> serviceCallback);

}
