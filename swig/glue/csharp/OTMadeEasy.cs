/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OtAPI {

using System;
using System.Runtime.InteropServices;

public class OTMadeEasy : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OTMadeEasy(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OTMadeEasy obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~OTMadeEasy() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_OTMadeEasy(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public OTMadeEasy() : this(otapiPINVOKE.new_OTMadeEasy(), true) {
  }

  public string register_nym(string SERVER_ID, string NYM_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_register_nym(swigCPtr, SERVER_ID, NYM_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string check_user(string SERVER_ID, string NYM_ID, string TARGET_NYM_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_check_user(swigCPtr, SERVER_ID, NYM_ID, TARGET_NYM_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string create_pseudonym(int nKeybits) {
    string ret = otapiPINVOKE.OTMadeEasy_create_pseudonym(swigCPtr, nKeybits);
    return ret;
  }

  public string issue_asset_type(string SERVER_ID, string NYM_ID, string THE_CONTRACT) {
    string ret = otapiPINVOKE.OTMadeEasy_issue_asset_type(swigCPtr, SERVER_ID, NYM_ID, THE_CONTRACT);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string retrieve_contract(string SERVER_ID, string NYM_ID, string CONTRACT_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_retrieve_contract(swigCPtr, SERVER_ID, NYM_ID, CONTRACT_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string load_or_retrieve_contract(string SERVER_ID, string NYM_ID, string CONTRACT_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_load_or_retrieve_contract(swigCPtr, SERVER_ID, NYM_ID, CONTRACT_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string create_asset_acct(string SERVER_ID, string NYM_ID, string ASSET_TYPE_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_create_asset_acct(swigCPtr, SERVER_ID, NYM_ID, ASSET_TYPE_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string stat_asset_account(string ACCOUNT_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_stat_asset_account(swigCPtr, ACCOUNT_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool retrieve_account(string SERVER_ID, string NYM_ID, string ACCOUNT_ID) {
    bool ret = otapiPINVOKE.OTMadeEasy_retrieve_account__SWIG_0(swigCPtr, SERVER_ID, NYM_ID, ACCOUNT_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool retrieve_account(string SERVER_ID, string NYM_ID, string ACCOUNT_ID, bool bForceDownload) {
    bool ret = otapiPINVOKE.OTMadeEasy_retrieve_account__SWIG_1(swigCPtr, SERVER_ID, NYM_ID, ACCOUNT_ID, bForceDownload);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string send_transfer(string SERVER_ID, string NYM_ID, string ACCT_FROM, string ACCT_TO, string AMOUNT, string NOTE) {
    string ret = otapiPINVOKE.OTMadeEasy_send_transfer(swigCPtr, SERVER_ID, NYM_ID, ACCT_FROM, ACCT_TO, AMOUNT, NOTE);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string process_inbox(string SERVER_ID, string NYM_ID, string ACCOUNT_ID, string RESPONSE_LEDGER) {
    string ret = otapiPINVOKE.OTMadeEasy_process_inbox(swigCPtr, SERVER_ID, NYM_ID, ACCOUNT_ID, RESPONSE_LEDGER);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string load_public_key(string NYM_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_load_public_key(swigCPtr, NYM_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string load_or_retrieve_pubkey(string SERVER_ID, string NYM_ID, string TARGET_NYM_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_load_or_retrieve_pubkey(swigCPtr, SERVER_ID, NYM_ID, TARGET_NYM_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string send_user_msg_pubkey(string SERVER_ID, string NYM_ID, string RECIPIENT_NYM_ID, string RECIPIENT_PUBKEY, string THE_MESSAGE) {
    string ret = otapiPINVOKE.OTMadeEasy_send_user_msg_pubkey(swigCPtr, SERVER_ID, NYM_ID, RECIPIENT_NYM_ID, RECIPIENT_PUBKEY, THE_MESSAGE);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string send_user_pmnt_pubkey(string SERVER_ID, string NYM_ID, string RECIPIENT_NYM_ID, string RECIPIENT_PUBKEY, string THE_INSTRUMENT) {
    string ret = otapiPINVOKE.OTMadeEasy_send_user_pmnt_pubkey(swigCPtr, SERVER_ID, NYM_ID, RECIPIENT_NYM_ID, RECIPIENT_PUBKEY, THE_INSTRUMENT);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string send_user_msg(string SERVER_ID, string NYM_ID, string RECIPIENT_NYM_ID, string THE_MESSAGE) {
    string ret = otapiPINVOKE.OTMadeEasy_send_user_msg(swigCPtr, SERVER_ID, NYM_ID, RECIPIENT_NYM_ID, THE_MESSAGE);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string send_user_payment(string SERVER_ID, string NYM_ID, string RECIPIENT_NYM_ID, string THE_PAYMENT) {
    string ret = otapiPINVOKE.OTMadeEasy_send_user_payment(swigCPtr, SERVER_ID, NYM_ID, RECIPIENT_NYM_ID, THE_PAYMENT);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_payment_instrument(string SERVER_ID, string NYM_ID, int nIndex) {
    string ret = otapiPINVOKE.OTMadeEasy_get_payment_instrument__SWIG_0(swigCPtr, SERVER_ID, NYM_ID, nIndex);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_payment_instrument(string SERVER_ID, string NYM_ID, int nIndex, string PRELOADED_INBOX) {
    string ret = otapiPINVOKE.OTMadeEasy_get_payment_instrument__SWIG_1(swigCPtr, SERVER_ID, NYM_ID, nIndex, PRELOADED_INBOX);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_box_receipt(string SERVER_ID, string NYM_ID, string ACCT_ID, int nBoxType, string TRANS_NUM) {
    string ret = otapiPINVOKE.OTMadeEasy_get_box_receipt(swigCPtr, SERVER_ID, NYM_ID, ACCT_ID, nBoxType, TRANS_NUM);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string retrieve_mint(string SERVER_ID, string NYM_ID, string ASSET_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_retrieve_mint(swigCPtr, SERVER_ID, NYM_ID, ASSET_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string load_or_retrieve_mint(string SERVER_ID, string NYM_ID, string ASSET_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_load_or_retrieve_mint(swigCPtr, SERVER_ID, NYM_ID, ASSET_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string query_asset_types(string SERVER_ID, string NYM_ID, string ENCODED_MAP) {
    string ret = otapiPINVOKE.OTMadeEasy_query_asset_types(swigCPtr, SERVER_ID, NYM_ID, ENCODED_MAP);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string create_market_offer(string SERVER_ID, string NYM_ID, string ASSET_ACCT_ID, string CURRENCY_ACCT_ID, string scale, string minIncrement, string quantity, string price, bool bSelling) {
    string ret = otapiPINVOKE.OTMadeEasy_create_market_offer(swigCPtr, SERVER_ID, NYM_ID, ASSET_ACCT_ID, CURRENCY_ACCT_ID, scale, minIncrement, quantity, price, bSelling);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string cancel_market_offer(string SERVER_ID, string NYM_ID, string ASSET_ACCT_ID, string TRANS_NUM) {
    string ret = otapiPINVOKE.OTMadeEasy_cancel_market_offer(swigCPtr, SERVER_ID, NYM_ID, ASSET_ACCT_ID, TRANS_NUM);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string cancel_payment_plan(string SERVER_ID, string NYM_ID, string ACCT_ID, string TRANS_NUM) {
    string ret = otapiPINVOKE.OTMadeEasy_cancel_payment_plan(swigCPtr, SERVER_ID, NYM_ID, ACCT_ID, TRANS_NUM);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string activate_smart_contract(string SERVER_ID, string NYM_ID, string ACCT_ID, string AGENT_NAME, string THE_SMART_CONTRACT) {
    string ret = otapiPINVOKE.OTMadeEasy_activate_smart_contract(swigCPtr, SERVER_ID, NYM_ID, ACCT_ID, AGENT_NAME, THE_SMART_CONTRACT);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string trigger_clause(string SERVER_ID, string NYM_ID, string TRANS_NUM, string CLAUSE_NAME, string STR_PARAM) {
    string ret = otapiPINVOKE.OTMadeEasy_trigger_clause(swigCPtr, SERVER_ID, NYM_ID, TRANS_NUM, CLAUSE_NAME, STR_PARAM);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string withdraw_cash(string SERVER_ID, string NYM_ID, string ACCT_ID, string AMOUNT) {
    string ret = otapiPINVOKE.OTMadeEasy_withdraw_cash(swigCPtr, SERVER_ID, NYM_ID, ACCT_ID, AMOUNT);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string withdraw_voucher(string SERVER_ID, string NYM_ID, string ACCT_ID, string RECIP_NYM_ID, string STR_MEMO, string AMOUNT) {
    string ret = otapiPINVOKE.OTMadeEasy_withdraw_voucher(swigCPtr, SERVER_ID, NYM_ID, ACCT_ID, RECIP_NYM_ID, STR_MEMO, AMOUNT);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string pay_dividend(string SERVER_ID, string NYM_ID, string SOURCE_ACCT_ID, string SHARES_ASSET_ID, string STR_MEMO, string AMOUNT_PER_SHARE) {
    string ret = otapiPINVOKE.OTMadeEasy_pay_dividend(swigCPtr, SERVER_ID, NYM_ID, SOURCE_ACCT_ID, SHARES_ASSET_ID, STR_MEMO, AMOUNT_PER_SHARE);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string deposit_cheque(string SERVER_ID, string NYM_ID, string ACCT_ID, string STR_CHEQUE) {
    string ret = otapiPINVOKE.OTMadeEasy_deposit_cheque(swigCPtr, SERVER_ID, NYM_ID, ACCT_ID, STR_CHEQUE);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_market_list(string SERVER_ID, string NYM_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_get_market_list(swigCPtr, SERVER_ID, NYM_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_market_offers(string SERVER_ID, string NYM_ID, string MARKET_ID, string MAX_DEPTH) {
    string ret = otapiPINVOKE.OTMadeEasy_get_market_offers(swigCPtr, SERVER_ID, NYM_ID, MARKET_ID, MAX_DEPTH);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_nym_market_offers(string SERVER_ID, string NYM_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_get_nym_market_offers(swigCPtr, SERVER_ID, NYM_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_market_recent_trades(string SERVER_ID, string NYM_ID, string MARKET_ID) {
    string ret = otapiPINVOKE.OTMadeEasy_get_market_recent_trades(swigCPtr, SERVER_ID, NYM_ID, MARKET_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string adjust_usage_credits(string SERVER_ID, string USER_NYM_ID, string TARGET_NYM_ID, string ADJUSTMENT) {
    string ret = otapiPINVOKE.OTMadeEasy_adjust_usage_credits(swigCPtr, SERVER_ID, USER_NYM_ID, TARGET_NYM_ID, ADJUSTMENT);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int VerifyMessageSuccess(string str_Message) {
    int ret = otapiPINVOKE.OTMadeEasy_VerifyMessageSuccess(swigCPtr, str_Message);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int VerifyMsgBalanceAgrmntSuccess(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string str_Message) {
    int ret = otapiPINVOKE.OTMadeEasy_VerifyMsgBalanceAgrmntSuccess(swigCPtr, SERVER_ID, USER_ID, ACCOUNT_ID, str_Message);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int VerifyMsgTrnxSuccess(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string str_Message) {
    int ret = otapiPINVOKE.OTMadeEasy_VerifyMsgTrnxSuccess(swigCPtr, SERVER_ID, USER_ID, ACCOUNT_ID, str_Message);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int InterpretTransactionMsgReply(string SERVER_ID, string USER_ID, string ACCOUNT_ID, string str_Attempt, string str_Response) {
    int ret = otapiPINVOKE.OTMadeEasy_InterpretTransactionMsgReply(swigCPtr, SERVER_ID, USER_ID, ACCOUNT_ID, str_Attempt, str_Response);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
