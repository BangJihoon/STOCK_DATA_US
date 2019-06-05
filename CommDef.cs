using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YOACOMClientCSharp
{
    class CommDef
    {
        //-------------------------------------------------------------------------------------------------------------------
        /**	@brief	로그타입코드
        */
        public static int YOALOG_TRAACE                     =   0;
        public static int YOALOG_ERROR						=   1;

        //-------------------------------------------------------------------------------------------------------------------
        /**	@brief	반환/응답코드
        */
        public static int RESULT_FAIL						=	-1;		    // API 실패 반환 코드
        public static int RESULT_SUCCESS					=	1000;	    // API 성공 반환 코드
        public static int RESPONSE_LOGIN_FAIL				=	1;		    // 로그인 실패 코드
        public static int RESPONSE_LOGIN_SUCCESS			=	2;		    // 로그인 성공 코드

        //-------------------------------------------------------------------------------------------------------------------
        /**	@brief	에러코드
        */
        public static int ERROR_MODULE_NOT_FOUND			=   11;		    // Yuanta Open API 모듈을 찾을 수 없습니다.
        public static int ERROR_FUNCTION_NOT_FOUND			=   12;		    // Yuanta Open API 함수를 찾을 수 없습니다.
        public static int ERROR_NOT_INITIAL					=   13;		    // Yuanta Open API 초기화 상태가 아닙니다.

        public static int ERROR_SYSTEM_CERT_ERROR			=	20;		    // 인증오류입니다.
        public static int ERROR_SYSTEM_MAX_CON				=   21;		    // 다중접속한도 초과입니다.
        public static int ERROR_SYSTEM_FORCE_KILL			=	22;		    // 강제 종료되었습니다.
        public static int ERROR_SYSTEM_EMERGENCY			=	23;		    // 시스템 비상 상황입니다.
        public static int ERROR_SYSTEM_INFINIT_CALL			=   24;		    // 이상 호출로 접속이 종료됩니다.
        public static int ERROR_SYSTEM_SOCKET_CLOSE         =   25;		    // 네트웍 연결이 끊어졌습니다.
                                                            
        public static int ERROR_NOT_LOGINED					=   101;		// 로그인 상태가 아닙니다.
        public static int ERROR_ALREADY_LOGINED				=   102;		// 이미 로그인된 상태입니다.
        public static int ERROR_INDEX_OUT_OF_BOUNDS			=   103;		// 인덱스가 가용범위를 넘었습니다.
        public static int ERROR_TIMEOUT_DATA				=   104;		// 타임아웃이 발생하였습니다.
        public static int ERROR_USERINFO_NOT_FOUND			=   105;		// 사용자 정보를 찾을 수 없습니다.
        public static int ERROR_ACCOUNT_NOT_FOUND			=   106;		// 계좌번호를 찾을 수 없습니다.
        public static int ERROR_ACCOUNT_PASSWORD_INCORRECT	=   107;		// 계좌 비밀번호를 잘못 입력하셨습니다.
        public static int ERROR_TYPE_NOT_FOUND				=   108;		// 요청한 타입을 찾을 수 없습니다.
                                                            
        public static int ERROR_CERT_PASSWORD_INCORRECT		=   110;		// 공인인증 비밀번호가 일치하지 않습니다.
        public static int ERROR_CERT_NOT_FOUND				=   111;		// 공인인증서를 찾을 수 없습니다.
        public static int ERROR_CETT_CANCEL_SELECT			=   112;		// 공인인증서 선택을 취소했습니다.
        public static int ERROR_NEED_TO_UPDATE				=   113;		// 공인인증 업데이트가 필요합니다.
        public static int ERROR_CERT_7_ERROR				=   114;		// 공인인증 7회 오류입니다.
        public static int ERROR_CERT_ERROR					=   115;		// 공인인증 오류입니다.
        public static int ERROR_CERT_PASSWORD_SHORTER		=   116;		// 공인인증서 비밀번호가 최소길이보다 짧습니다.
        public static int ERROR_ID_SHORTER					=   117;		// 로그인 아이디가 최소길이보다 짧습니다.
        public static int ERROR_ID_PASSWORD_SHORTER			=   118;		// 로그인 비밀번호가 최소길이보다 짧습니다.

        public static int ERROR_CERT_OLD					=	121;		// 폐기된 인증서 입니다.
        public static int ERROR_CERT_TIME_OVER				=   122;		// 만료된 인증서 입니다.
        public static int ERROR_CERT_STOP					=	123;		// 정지된 인증서 입니다.
        public static int ERROR_CERT_NOTMATCH_SN			=	124;		// SN이 일치하지 않는 인증서입니다.
        public static int ERROR_CERT_ETC					=	125;		// 기타오류 인증서입니다.
        public static int ERROR_CERT_TIME_OUT               =   126;		// 타인증기관 발급 인증서 검증에서 타임아웃이 발생하였습니다. 다시 시도해 주십시오
                                                            
        public static int ERROR_REQUEST_FAIL				=   201;		// DSO 요청이 실패하였습니다.
        public static int ERROR_DSO_NOT_FOUND				=   202;		// DSO를 찾을 수 없습니다.
        public static int ERROR_BLOCK_NOT_FOUND				=   203;		// 블록을 찾을 수 없습니다..
        public static int ERROR_FIELD_NOT_FOUND				=   204;		// 필드를 찾을 수 없습니다.
        public static int ERROR_REQUEST_NOT_FOUND			=   205;		// 요청 정보를 찾을 수 없습니다.
        public static int ERROR_ATTR_NOT_FOUND				=   206;		// 필드의 속성을 찾을 수 없습니다.
        public static int ERROR_REGIST_FAIL					=   207;		// AUTO 등록이 실패하였습니다.
        public static int ERROR_AUTO_NOT_FOUND				=   208;		// AUTO를 찾을 수 없습니다.
        public static int ERROR_KEY_NOT_FOUND				=   209;		// 요청한 키를 찾을 수 없습니다.
        public static int ERROR_VALUE_NOT_FOUND             =   210;		// 요청한 값을 찾을 수 없습니다.

        public static int ERROR_MAX_CODE					=   RESULT_SUCCESS;

        //-------------------------------------------------------------------------------------------------------------------
        /**	@brief	시스템 통보 코드
        */
        public static int NOTIFY_SYSTEM_NEED_TO_RESTART         = 26;		// 모듈 변경에 따른 재시작 필요
        public static int NOTIFY_SYSTEM_LOGIN_START			    = 27;		// 로그인을 시작합니다.
        public static int NOTIFY_SYSTEM_LOGIN_REQ_USERINFO	    = 28;		// 사용자 정보를 요청합니다.
        public static int NOTIFY_SYSTEM_LOGIN_RCV_USERINFO	    = 29;		// 사용자 정보를 수신했습니다.
        public static int NOTIFY_SYSTEM_LOGIN_FILE_DWN_START	= 30;		// 파일 다운로드를 시작합니다.
        public static int NOTIFY_SYSTEM_LOGIN_FILE_DWN_END	    = 31;		// 파일 다운로드가 완료되었습니다.

        //-------------------------------------------------------------------------------------------------------------------
        /**	@brief	계좌정보코드
        */
        public static int ACCOUNT_INFO_NAME					=   1;  		// 계좌명
        public static int ACCOUNT_INFO_NICKNAME				=   2;  		// 계좌별명
        public static int ACCOUNT_INFO_TYPE					=   3;  		// 상품구분

        //-------------------------------------------------------------------------------------------------------------------
        /**	@brief	종목정보코드
        */
        public static int MARKET_TYPE_INTERNAL				=   0;		    // 국내(주식,선물옵션)
        public static int MARKET_TYPE_GLOBAL_STOCK			=   1;		    // 해외주식
        public static int MARKET_TYPE_GLOBAL_DERIVATIVE     =   2;		    // 해외선물옵션
        public static int MARKET_TYPE_INTERNAL_STOCK        =   3;		    // 국내 주식
        public static int MARKET_TYPE_INTERNAL_KOSPIFUTURE  =   4;		    // 국내 코스피선물
        public static int MARKET_TYPE_INTERNAL_KOSPIOPTION  =   5;		    // 국내 코스피옵션

        public static int CODE_INFO_CODE                    =   0;  		// 종목코드
        public static int CODE_INFO_STANDARD_CODE           =   1;  		// 표준 종목코드
        public static int CODE_INFO_NAME					=	2;  		// 한글 종목명
        public static int CODE_INFO_ENG_NAME				=	3;  		// 영문 종목명
        public static int CODE_INFO_JANG_GUBUN              =   4;  		// 장구분
    }
}
