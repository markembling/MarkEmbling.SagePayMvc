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

namespace SagePayMvc.Internal {
	/// <summary>
	/// Utility class to help with unit testing.
	/// </summary>
	public static class TestHelper {
		public const string ValidSecurityKey = "testkey123";
		public const string ValidSignature = "89E1B763A6A687F7A237E7EBF6B99765";
		public const string VendorName = "testvendor";

		public static SagePayResponse CreateValidResponse() {
			return new SagePayResponse
			{
				VendorTxCode = "2005296905ead38e3cd845e19df728a2cac8bb73",
				VPSTxId = "{5C24A0B8-416E-9806-35F0-D0514B7EDEA6}",
				Status = ResponseType.Ok,
				StatusDetail = "0000 : The Authorisation was Successful.",
				TxAuthNo = "20005102",
				AVSCV2 = "SECURITY CODE MATCH ONLY",
				AddressResult = "NOTMATCHED",
				PostCodeResult = "NOTMATCHED",
				CV2Result = "MATCHED",
				GiftAid = "0",
				ThreeDSecureStatus = "NOTCHECKED",
				CAVV = "",
				AddressStatus = "",
				PayerStatus = "",
				CardType = "VISA",
				Last4Digits = "0006",
				DeclineCode = "00",
				ExpiryDate = "0124",
				FraudResponse = "",
				BankAuthCode = "999777",
				ACSTransID = "",
				DSTransID = "",
				SchemeTraceID = "MSwnHPqcouZtJVemiIootJRzCfCpRiNqkRhPt0IS011dKzIFlHoozpyj",

				VPSSignature = ValidSignature
			};
		}
	}
}