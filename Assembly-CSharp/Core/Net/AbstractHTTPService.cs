using System;
using System.Runtime.CompilerServices;
using BestHTTP;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Net
{
	// Token: 0x02000E84 RID: 3716
	[Token(Token = "0x2000E84")]
	public abstract class AbstractHTTPService : IDisposable
	{
		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06005A61 RID: 23137 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A62 RID: 23138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700126A")]
		public Uri Uri
		{
			[Token(Token = "0x6005A61")]
			[Address(RVA = "0xA762", Offset = "0xA762", VA = "0xA762")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A62")]
			[Address(RVA = "0xA763", Offset = "0xA763", VA = "0xA763")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A63")]
		[Address(RVA = "0xA764", Offset = "0xA764", VA = "0xA764", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4 Core_Net_AbstractHTTPService__Dispose(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  int *local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6057c == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_HTTPRequest_TypeInfo);
		    DAT_ram_00a6057c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(BestHTTP_HTTPRequest_TypeInfo);
		  BestHTTP_HTTPRequest___ctor(param1_00,param2,0,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,param1_00,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a6057e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractHTTPService__SetupAuthHeader_d__10___
		              );
		    DAT_ram_00a6057e = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = param1_00;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractGame__InitCompleted_d__257_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractHTTPService__SetupAuthHeader_d__10___
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A64")]
		[Address(RVA = "0x225C", Offset = "0x225C", VA = "0x225C")]
		protected AbstractHTTPService(Uri uri, IAuthTokenSource authTokenSource, TimeSpan timeout)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_AbstractHTTPService___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__Dispose
		            (param1,param2,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A65")]
		[Address(RVA = "0xA765", Offset = "0xA765", VA = "0xA765", Slot = "6")]
		protected virtual HTTPRequest CreateGet(Uri uri)
		{
		/* --- GHIDRA: CreateGet ---
		undefined4 Core_Net_AbstractHTTPService__CreateGet(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  int *local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6057d == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_HTTPRequest_TypeInfo);
		    DAT_ram_00a6057d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(BestHTTP_HTTPRequest_TypeInfo);
		  BestHTTP_HTTPRequest___ctor(param1_00,param2,2,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,param1_00,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a6057e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractHTTPService__SetupAuthHeader_d__10___
		              );
		    DAT_ram_00a6057e = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = param1_00;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractGame__InitCompleted_d__257_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractHTTPService__SetupAuthHeader_d__10___
		            );
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A66")]
		[Address(RVA = "0xA766", Offset = "0xA766", VA = "0xA766", Slot = "7")]
		protected virtual HTTPRequest CreatePost(Uri uri)
		{
		/* --- GHIDRA: CreatePost ---
		void Core_Net_AbstractHTTPService__CreatePost(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6057e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractHTTPService__SetupAuthHeader_d__10___
		              );
		    DAT_ram_00a6057e = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractGame__InitCompleted_d__257_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractHTTPService__SetupAuthHeader_d__10___
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A67")]
		[Address(RVA = "0xA767", Offset = "0xA767", VA = "0xA767")]
		private void SetupAuthHeader(HTTPRequest request)
		{
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0xA768", Offset = "0xA768", VA = "0xA768", Slot = "8")]
		protected virtual void SetupHeaders(HTTPRequest request)
		{
		}

		// Token: 0x04003158 RID: 12632
		[Token(Token = "0x4003158")]
		[FieldOffset(Offset = "0x8")]
		public readonly TimeSpan Timeout;

		// Token: 0x0400315A RID: 12634
		[Token(Token = "0x400315A")]
		[FieldOffset(Offset = "0x14")]
		public readonly IAuthTokenSource AuthTokenSource;
	}
}
