using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Gameplay.Managers.Ad.Placements;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Services;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Providers
{
	// Token: 0x02001200 RID: 4608
	[Token(Token = "0x2001200")]
	public class WebglAdProvider : IAdProvider, IDisposable
	{
		// Token: 0x140002D7 RID: 727
		// (add) Token: 0x06006D61 RID: 28001 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D62 RID: 28002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D7")]
		public event Action<IAdProvider.BaseAdEventData> AdClosedEvent
		{
			[Token(Token = "0x6006D61")]
			[Address(RVA = "0xB83C", Offset = "0xB83C", VA = "0xB83C", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D62")]
			[Address(RVA = "0xB83D", Offset = "0xB83D", VA = "0xB83D", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D8 RID: 728
		// (add) Token: 0x06006D63 RID: 28003 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D64 RID: 28004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D8")]
		public event Action<IAdProvider.AdAvailabilityEventData> AdAvailabilityChangedEvent
		{
			[Token(Token = "0x6006D63")]
			[Address(RVA = "0xB83E", Offset = "0xB83E", VA = "0xB83E", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D64")]
			[Address(RVA = "0xB83F", Offset = "0xB83F", VA = "0xB83F", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D9 RID: 729
		// (add) Token: 0x06006D65 RID: 28005 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D66 RID: 28006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D9")]
		public event Action<IAdProvider.AdErrorEventData> AdErrorEvent
		{
			[Token(Token = "0x6006D65")]
			[Address(RVA = "0xB840", Offset = "0xB840", VA = "0xB840", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D66")]
			[Address(RVA = "0xB841", Offset = "0xB841", VA = "0xB841", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002DA RID: 730
		// (add) Token: 0x06006D67 RID: 28007 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D68 RID: 28008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DA")]
		public event Action<IAdProvider.AdInfoEventData> AdRewardedEvent
		{
			[Token(Token = "0x6006D67")]
			[Address(RVA = "0xB842", Offset = "0xB842", VA = "0xB842", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D68")]
			[Address(RVA = "0xB843", Offset = "0xB843", VA = "0xB843", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x00014190 File Offset: 0x00012390
		[Token(Token = "0x1700163F")]
		public AdSource ProviderId
		{
			[Token(Token = "0x6006D69")]
			[Address(RVA = "0xB844", Offset = "0xB844", VA = "0xB844", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return AdSource.UnknownSource;
			}
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6A")]
		[Address(RVA = "0xB845", Offset = "0xB845", VA = "0xB845")]
		public WebglAdProvider(AdSource providerId)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider___ctor
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x000141A8 File Offset: 0x000123A8
		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0xB846", Offset = "0xB846", VA = "0xB846", Slot = "13")]
		public UniTask Init(string userId, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__Init
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  undefined4 *param2_01;
		  int iVar5;
		  uint uVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 local_4c;
		  undefined4 local_48;
		  undefined4 local_44;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  int local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a771 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Providers_WebglAdProvider_AdInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_WebglAdProvider_AdInfo__Add__);
		    DAT_ram_00a5a771 = '\x01';
		  }
		  uVar1 = IronSourceJSON_Json__Deserialize(param3,0);
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_Ad_Providers_WebglAdProvider_AdInfo_TypeInfo)
		  ;
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = param2;
		  iVar4 = Method_System_Collections_Generic_List_WebglAdProvider_AdInfo__Add__;
		  iVar5 = *(int *)(param1 + 0x1c);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar2;
		code_r0x8126880f:
		    local_44 = *(undefined4 *)(param1 + 0x18);
		    DAT_ram_009d3e38 = 0;
		    local_48 = 0xffffffff;
		    local_4c = Protocol_Services_AdSource_TypeInfo;
		    uVar8 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x293,&local_4c,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (DAT_ram_00a5a772 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__ShowAdAsync_d__24___
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a5a772 = '\x01';
		          goto code_r0x812688ab;
		        }
		      }
		      else {
		code_r0x812688ab:
		        local_4 = 0;
		        local_c = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ef,&local_40,0)
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		          local_24 = local_38;
		          local_2c = local_40;
		          local_30 = 0xffffffff;
		          DAT_ram_009d3e38 = 0;
		          local_1c = uVar8;
		          local_18 = param2;
		          local_14 = uVar1;
		          local_10 = param1;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x331,&local_2c,&local_30,
		                     Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__ShowAdAsync_d__24___
		                    );
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,iVar2,
		               *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) goto code_r0x8126880f;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar4 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar5) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar3);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        if (iVar5 != 0) {
		          piVar7 = (int *)*puVar3;
		          import::env::__cxa_end_catch();
		          uVar8 = *(undefined4 *)(param1 + 0x1c);
		          uVar1 = unnamed_function_2232
		                            (&
		                             Method_System_Collections_Generic_List_WebglAdProvider_AdInfo__Remove__
		                            );
		          func_ii_4876(uVar8,iVar2,uVar1);
		          uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe8) * 4))
		                            (piVar7,*(undefined4 *)(*piVar7 + 0xec));
		          uVar8 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x110) * 4))
		                            (piVar7,*(undefined4 *)(*piVar7 + 0x114));
		          param2_00 = unnamed_function_2232(&StringLiteral_47);
		          uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                            (uVar1,param2_00,uVar8,0);
		          iVar4 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar4 + 0x74) == 0) {
		            func_ii_306000(iVar4);
		          }
		          func_ii_7109(uVar1,0);
		          iVar4 = *(int *)(param1 + 0x10);
		          if (iVar4 != 0) {
		            uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe8) * 4))
		                              (piVar7,*(undefined4 *)(*piVar7 + 0xec));
		            uVar8 = unnamed_function_2232
		                              (&
		                               Core_Gameplay_Managers_Ad_Providers_IAdProvider_AdErrorEventData_TypeInfo
		                              );
		            iVar2 = unnamed_function_1417(uVar8);
		            uVar8 = unnamed_function_2232(&StringLiteral_11647);
		            *(undefined4 *)(iVar2 + 0x14) = uVar1;
		            *(undefined4 *)(iVar2 + 0x10) = 0;
		            *(undefined4 *)(iVar2 + 0xc) = uVar8;
		            *(int *)(iVar2 + 8) = param1;
		            (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                      (*(undefined4 *)(iVar4 + 0x20),iVar2,*(undefined4 *)(iVar4 + 0x14));
		          }
		          return;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81268b6d;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81268b6d:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6C")]
		[Address(RVA = "0xB847", Offset = "0xB847", VA = "0xB847", Slot = "14")]
		public void ShowAd(string placementName, Dictionary<string, string> payload)
		{
		/* --- GHIDRA: ShowAd ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__ShowAd
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a772 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__ShowAdAsync_d__24___
		              );
		    DAT_ram_00a5a772 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_40,0);
		  local_24 = local_38;
		  local_30 = 0xffffffff;
		  local_2c = local_40;
		  local_1c = param2;
		  local_18 = param3;
		  local_14 = param4;
		  local_10 = param1;
		  func_ii_8756(&local_2c,&local_30,
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__ShowAdAsync_d__24___
		              );
		  return;
		}
		*/

		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6D")]
		[Address(RVA = "0xB848", Offset = "0xB848", VA = "0xB848")]
		private void ShowAdAsync(string providerName, string adName, string payload)
		{
		/* --- GHIDRA: ShowAdAsync ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__ShowAdAsync
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a774 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Providers_IAdProvider_AdErrorEventData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Providers_WebglAdProvider_Status_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9357);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14654);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12332);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11606);
		    DAT_ram_00a5a774 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  local_4 = param3;
		  uVar1 = func_ii_1081(Core_Gameplay_Managers_Ad_Providers_WebglAdProvider_Status_TypeInfo,&local_4)
		  ;
		  uVar1 = func_ii_4419(StringLiteral_14654,uVar1,0);
		  func_ii_2010(param1_00,uVar1,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_12332,*(undefined4 *)(param2 + 0xc),StringLiteral_47,0);
		  func_ii_2010(param1_00,uVar1,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                    (StringLiteral_9357,*(undefined4 *)(param2 + 0x10),0);
		  func_ii_2010(param1_00,uVar1,0);
		  iVar4 = *(int *)(param1 + 0x10);
		  if (iVar4 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		    iVar3 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Ad_Providers_IAdProvider_AdErrorEventData_TypeInfo);
		    uVar1 = StringLiteral_11606;
		    *(undefined4 *)(iVar3 + 0x14) = uVar2;
		    *(undefined4 *)(iVar3 + 0x10) = 0;
		    *(undefined4 *)(iVar3 + 0xc) = uVar1;
		    *(int *)(iVar3 + 8) = param1;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),iVar3,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x223D", Offset = "0x223D", VA = "0x223D")]
		private void ShowAdResponseHandler(WebglAdProvider.ShowAdResponse response)
		{
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0xB849", Offset = "0xB849", VA = "0xB849")]
		private void CallAdErrorEvent(WebglAdProvider.ShowAdResponse response, WebglAdProvider.Status status)
		{
		/* --- GHIDRA: CallAdErrorEvent ---
		/* WARNING: Removing unreachable block (ram,0x8126904c) */
		
		undefined4
		Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__CallAdErrorEvent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  int iVar6;
		  undefined4 *param2_01;
		  int *piVar7;
		  undefined4 local_48;
		  undefined4 local_44;
		  undefined4 local_40;
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  int local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a775 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Services_AdSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    DAT_ram_00a5a775 = '\x01';
		  }
		  if (*(char *)(param1 + 0x21) != '\0') {
		    bVar1 = *(byte *)(param1 + 0x20);
		    uVar2 = unnamed_function_1417(Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    UnityEngine_UIElements_VisualElement_VisualElementScheduledItem___Il2CppFullySharedGenericType____ctor
		              (uVar2,(uint)bVar1,Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    return uVar2;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    *(undefined1 *)(param1 + 0x21) = 1;
		    local_40 = *(undefined4 *)(param1 + 0x18);
		    DAT_ram_009d3e38 = 0;
		    local_44 = 0xffffffff;
		    local_48 = Protocol_Services_AdSource_TypeInfo;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x293,&local_48,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (DAT_ram_00a5a776 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__CheckAvailAdsAsync_d__28___
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a5a776 = '\x01';
		          goto code_r0x812690f1;
		        }
		      }
		      else {
		code_r0x812690f1:
		        local_8 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ef,&local_3c,0)
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		          local_20 = local_34;
		          local_28 = local_3c;
		          local_14 = 0;
		          local_2c = 0xffffffff;
		          DAT_ram_009d3e38 = 0;
		          local_18 = uVar5;
		          local_10 = param1;
		          local_c = uVar2;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x333,&local_28,&local_2c,
		                     Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__CheckAvailAdsAsync_d__28___
		                    );
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            return uVar2;
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar3 != 0) {
		          piVar7 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          *(undefined1 *)(param1 + 0x21) = 0;
		          uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe8) * 4))
		                            (piVar7,*(undefined4 *)(*piVar7 + 0xec));
		          uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x110) * 4))
		                            (piVar7,*(undefined4 *)(*piVar7 + 0x114));
		          param2_00 = unnamed_function_2232(&StringLiteral_47);
		          uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                            (uVar2,param2_00,uVar5,0);
		          iVar6 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar6 + 0x74) == 0) {
		            func_ii_306000(iVar6);
		          }
		          func_ii_7109(uVar2,0);
		          uVar2 = unnamed_function_2232(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		          uVar2 = unnamed_function_1417(uVar2);
		          uVar5 = unnamed_function_2232(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		          UnityEngine_UIElements_VisualElement_VisualElementScheduledItem___Il2CppFullySharedGenericType____ctor
		                    (uVar2,0,uVar5);
		          return uVar2;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8126934e;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x8126934e:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D70")]
		[Address(RVA = "0xB84A", Offset = "0xB84A", VA = "0xB84A", Slot = "15")]
		public WaitForCallBack<bool> IsAdAvailable(IAdPlacementData placement)
		{
		/* --- GHIDRA: IsAdAvailable ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__IsAdAvailable
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a776 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__CheckAvailAdsAsync_d__28___
		              );
		    DAT_ram_00a5a776 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param2;
		  local_14 = param3;
		  local_10 = param1;
		  local_c = param4;
		  Utils_CoroutineUtils_WaitForCallBack_bool____ctor
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_WebglAdProvider__CheckAvailAdsAsync_d__28___
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D71")]
		[Address(RVA = "0xB84B", Offset = "0xB84B", VA = "0xB84B")]
		private void CheckAvailAdsAsync(string providerName, string adName, WaitForCallBack<bool> waitForCallBack)
		{
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D72")]
		[Address(RVA = "0x223A", Offset = "0x223A", VA = "0x223A")]
		private void CheckAdResponseHandler(bool isAvailable, WaitForCallBack<bool> waitForCallBack)
		{
		/* --- GHIDRA: CheckAdResponseHandler ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__CheckAdResponseHandler
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a52931 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_ExternAppMethods_ShowAdCallback__);
		    Mono_Security_ASN1__get_Item(&Core_ExternAppMethods_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TypeInfo);
		    DAT_ram_00a52931 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TypeInfo);
		  *(undefined4 *)(*(int *)(Core_ExternAppMethods_TypeInfo + 0x5c) + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,0,Method_Core_ExternAppMethods_ShowAdCallback__,0);
		  param1_00 = unnamed_function_1428(param2);
		  param2_00 = unnamed_function_1428(param3);
		  param3_00 = unnamed_function_1428(param4);
		  uVar1 = unnamed_function_1434(uVar1);
		  import::env::ShowAd(param1_00,param2_00,param3_00,uVar1);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(param2_00);
		  unnamed_function_1427(param3_00);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource_object___UnsafeGetStatus
		            (&local_c,*(undefined4 *)(*(int *)(Core_ExternAppMethods_TypeInfo + 0x5c) + 0xc),
		             Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		  *(undefined4 *)(param1 + 1) = local_4;
		  *param1 = local_c;
		  return;
		}
		*/

		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D73")]
		[Address(RVA = "0xB84C", Offset = "0xB84C", VA = "0xB84C", Slot = "16")]
		public void Dispose()
		{
		}

		// Token: 0x04003940 RID: 14656
		[Token(Token = "0x4003940")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<WebglAdProvider.AdInfo> _currentAds;

		// Token: 0x04003941 RID: 14657
		[Token(Token = "0x4003941")]
		[FieldOffset(Offset = "0x20")]
		private bool _lastAvailabilityResponse;

		// Token: 0x04003942 RID: 14658
		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x21")]
		private bool _waitingForResponse;

		// Token: 0x02001201 RID: 4609
		[Token(Token = "0x2001201")]
		[Serializable]
		public class ShowAdResponse
		{
			// Token: 0x06006D74 RID: 28020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D74")]
			[Address(RVA = "0xB84D", Offset = "0xB84D", VA = "0xB84D")]
			public ShowAdResponse()
			{
			}

			// Token: 0x04003943 RID: 14659
			[Token(Token = "0x4003943")]
			[FieldOffset(Offset = "0x8")]
			public string status;

			// Token: 0x04003944 RID: 14660
			[Token(Token = "0x4003944")]
			[FieldOffset(Offset = "0xC")]
			public string result;

			// Token: 0x04003945 RID: 14661
			[Token(Token = "0x4003945")]
			[FieldOffset(Offset = "0x10")]
			public string info;
		}

		// Token: 0x02001202 RID: 4610
		[Token(Token = "0x2001202")]
		[Serializable]
		private class AdInfo
		{
			// Token: 0x06006D75 RID: 28021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D75")]
			[Address(RVA = "0xB84E", Offset = "0xB84E", VA = "0xB84E")]
			public AdInfo()
			{
			}

			// Token: 0x04003946 RID: 14662
			[Token(Token = "0x4003946")]
			[FieldOffset(Offset = "0x8")]
			public string AdName;

			// Token: 0x04003947 RID: 14663
			[Token(Token = "0x4003947")]
			[FieldOffset(Offset = "0xC")]
			public string Payload;
		}

		// Token: 0x02001203 RID: 4611
		[Token(Token = "0x2001203")]
		public enum Status
		{
			// Token: 0x04003949 RID: 14665
			[Token(Token = "0x4003949")]
			Unknown,
			// Token: 0x0400394A RID: 14666
			[Token(Token = "0x400394A")]
			Success,
			// Token: 0x0400394B RID: 14667
			[Token(Token = "0x400394B")]
			Cancel,
			// Token: 0x0400394C RID: 14668
			[Token(Token = "0x400394C")]
			Fail
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AdClosedEvent ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__add_AdClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a769 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_BaseAdEventData__TypeInfo);
		    DAT_ram_00a5a769 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAdProvider_BaseAdEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdProvider_BaseAdEventData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_AdClosedEvent ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__remove_AdClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a76a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo);
		    DAT_ram_00a5a76a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_AdAvailabilityChangedEvent ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__add_AdAvailabilityChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a76b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo);
		    DAT_ram_00a5a76b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdProvider_AdAvailabilityEventData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_AdAvailabilityChangedEvent ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__remove_AdAvailabilityChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a76c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdErrorEventData__TypeInfo);
		    DAT_ram_00a5a76c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAdProvider_AdErrorEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdProvider_AdErrorEventData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_AdErrorEvent ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__add_AdErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a76d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdErrorEventData__TypeInfo);
		    DAT_ram_00a5a76d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAdProvider_AdErrorEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdProvider_AdErrorEventData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_AdErrorEvent ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__remove_AdErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a76e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdInfoEventData__TypeInfo);
		    DAT_ram_00a5a76e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAdProvider_AdInfoEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdProvider_AdInfoEventData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_AdRewardedEvent ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__add_AdRewardedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a76f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdProvider_AdInfoEventData__TypeInfo);
		    DAT_ram_00a5a76f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAdProvider_AdInfoEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdProvider_AdInfoEventData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_ProviderId ---
		void Core_Gameplay_Managers_Ad_Providers_WebglAdProvider__get_ProviderId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a770 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_WebglAdProvider_AdInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_WebglAdProvider_AdInfo__TypeInfo);
		    DAT_ram_00a5a770 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_WebglAdProvider_AdInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_WebglAdProvider_AdInfo___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

}
