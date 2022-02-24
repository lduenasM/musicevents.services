using MusicEvents.Dto.Request;
using MusicEvents.Dto.Response;

namespace MusicEvents.Services.Interfaces;

public interface IUserService
{
    Task<BaseResponseGeneric<string>> RegisterAsync(DtoRegisterUser request);

    Task<DtoLoginResponse> LoginAsync(DtoLogin request);

    Task<BaseResponseGeneric<string>> SendTokenToResetPasswordAsync(DtoResetPassword request);


    /*
     * ROL: ADMINISTRADOR
     *  - Supervisor (Claim)
     *      - x
     *       - 4
     *  - Gerente
     *  - Jefe
     * ROL: CLIENTE
     *  - Cliente
     */
    Task<BaseResponseGeneric<string>> ResetPassword(DtoConfirmReset request);

    Task<BaseResponse> ChangePassword(DtoChangePassword request);
}
