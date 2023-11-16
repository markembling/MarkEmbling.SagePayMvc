#region License

// Copyright 2009 The Sixth Form College Farnborough (http://www.farnborough.ac.uk)
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
// 
// The latest version of this file can be found at http://github.com/JeremySkinner/SagePayMvc

#endregion

using System.Collections.Generic;
using System.Web.Mvc;
using SagePayMvc.Internal;

namespace SagePayMvc {
	/// <summary>
	/// IModelBinder implementation for deserializing a notification post into a SagePayResponse object.
	/// </summary>
	public class SagePayBinder : IModelBinder {
		const string Status = "Status";
		const string VendorTxCode = "VendorTxCode";
		const string VPSTxId = "VPSTxId";
		const string VPSSignature = "VPSSignature";
		const string StatusDetail = "StatusDetail";
		const string TxAuthNo = "TxAuthNo";
		const string AVSCV2 = "AVSCV2";
		const string AddressResult = "AddressResult";
		const string PostCodeResult = "PostCodeResult";
		const string CV2Result = "CV2Result";
		const string GiftAid = "GiftAid";
		const string ThreeDSecureStatus = "3DSecureStatus";
		const string CAVV = "CAVV";
		const string AddressStatus = "AddressStatus";
		const string PayerStatus = "PayerStatus";
		const string CardType = "CardType";
		const string Last4Digits = "Last4Digits";
		const string DeclineCode = "DeclineCode";
		const string ExpiryDate = "ExpiryDate";
		const string FraudResponse = "FraudResponse";
		const string BankAuthCode = "BankAuthCode";
		const string ACSTransID = "ACSTransID";
		const string DSTransID = "DSTransID";
		const string SchemeTraceID = "SchemeTraceID";


        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) {
			var response = new SagePayResponse();
			response.Status = GetStatus(bindingContext.ValueProvider);
			response.VendorTxCode = GetFormField(VendorTxCode, bindingContext.ValueProvider);
			response.VPSTxId = GetFormField(VPSTxId, bindingContext.ValueProvider);
			response.VPSSignature = GetFormField(VPSSignature, bindingContext.ValueProvider);
			response.StatusDetail = GetFormField(StatusDetail, bindingContext.ValueProvider);
			response.TxAuthNo = GetFormField(TxAuthNo, bindingContext.ValueProvider);
			response.AVSCV2 = GetFormField(AVSCV2, bindingContext.ValueProvider);
			response.AddressResult = GetFormField(AddressResult, bindingContext.ValueProvider);
			response.PostCodeResult = GetFormField(PostCodeResult, bindingContext.ValueProvider);
			response.CV2Result = GetFormField(CV2Result, bindingContext.ValueProvider);
			response.GiftAid = GetFormField(GiftAid, bindingContext.ValueProvider);
			response.ThreeDSecureStatus = GetFormField(ThreeDSecureStatus, bindingContext.ValueProvider);
			response.CAVV = GetFormField(CAVV, bindingContext.ValueProvider);
			response.AddressStatus = GetFormField(AddressStatus, bindingContext.ValueProvider);
			response.PayerStatus = GetFormField(PayerStatus, bindingContext.ValueProvider);
			response.CardType = GetFormField(CardType, bindingContext.ValueProvider);
			response.Last4Digits = GetFormField(Last4Digits, bindingContext.ValueProvider);
			response.DeclineCode = GetFormField(DeclineCode, bindingContext.ValueProvider);
			response.ExpiryDate = GetFormField(ExpiryDate, bindingContext.ValueProvider);
			response.FraudResponse = GetFormField(FraudResponse, bindingContext.ValueProvider);
			response.BankAuthCode = GetFormField(BankAuthCode, bindingContext.ValueProvider);
			response.ACSTransID = GetFormField(ACSTransID, bindingContext.ValueProvider);
			response.DSTransID = GetFormField(DSTransID, bindingContext.ValueProvider);
			response.SchemeTraceID = GetFormField(SchemeTraceID, bindingContext.ValueProvider);
			return response;
		}

		ResponseType GetStatus(IValueProvider valueProvider) {
			string value = GetFormField(Status, valueProvider);
			return ResponseSerializer.ConvertStringToSagePayResponseType(value);
		}

		string GetFormField(string key, IValueProvider provider) {
			ValueProviderResult result = provider.GetValue(key);

			if(result != null) {
				return (string)result.ConvertTo(typeof(string));
			}

			return null;
		}
	}
}