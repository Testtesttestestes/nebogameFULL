using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200125A RID: 4698
	[Token(Token = "0x200125A")]
	public class PlatformSigninManager : IAppManager, IBaseManager
	{
		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06006F5E RID: 28510 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F5F RID: 28511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BD")]
		public IApp Application
		{
			[Token(Token = "0x6006F5E")]
			[Address(RVA = "0xB9C8", Offset = "0xB9C8", VA = "0xB9C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F5F")]
			[Address(RVA = "0xB9C9", Offset = "0xB9C9", VA = "0xB9C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06006F60 RID: 28512 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F61 RID: 28513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BE")]
		public IPlatformSigninProvider CurrentProvider
		{
			[Token(Token = "0x6006F60")]
			[Address(RVA = "0xB9CA", Offset = "0xB9CA", VA = "0xB9CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F61")]
			[Address(RVA = "0xB9CB", Offset = "0xB9CB", VA = "0xB9CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016BF")]
		public IPlatformSigninProvider TargetProvider
		{
			[Token(Token = "0x6006F62")]
			[Address(RVA = "0xB9CC", Offset = "0xB9CC", VA = "0xB9CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002EF RID: 751
		// (add) Token: 0x06006F63 RID: 28515 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F64 RID: 28516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EF")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F63")]
			[Address(RVA = "0xB9CD", Offset = "0xB9CD", VA = "0xB9CD", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F64")]
			[Address(RVA = "0xB9CE", Offset = "0xB9CE", VA = "0xB9CE", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F0 RID: 752
		// (add) Token: 0x06006F65 RID: 28517 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F66 RID: 28518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F0")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F65")]
			[Address(RVA = "0xB9CF", Offset = "0xB9CF", VA = "0xB9CF", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F66")]
			[Address(RVA = "0xB9D0", Offset = "0xB9D0", VA = "0xB9D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F67")]
		[Address(RVA = "0xB9D1", Offset = "0xB9D1", VA = "0xB9D1")]
		public PlatformSigninManager(IApp application)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_PlatformSigninManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a844 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PlatformSigninManager__Init_d__19___
		              );
		    DAT_ram_00a5a844 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_OkgAnalytics__UpdateTokenAndSendLogAgain_d__52_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PlatformSigninManager__Init_d__19___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F68")]
		[Address(RVA = "0xB9D2", Offset = "0xB9D2", VA = "0xB9D2", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_PlatformSigninManager__Init
		               (undefined8 *param1,int param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a845 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo)
		    ;
		    DAT_ram_00a5a845 = '\x01';
		  }
		  *(int **)(param2 + 0xc) = param3;
		  iVar1 = *param3;
		  if (((uint)*(byte *)(Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo + 0xb8) <=
		       (uint)*(byte *)(iVar1 + 0xb8)) &&
		     (*(int *)(*(int *)(iVar1 + 100) +
		               (uint)*(byte *)(Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo +
		                              0xb8) * 4 + -4) ==
		      Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		              (&local_c,param3,*(undefined4 *)(iVar1 + 0x14c));
		    *(undefined4 *)(param1 + 1) = local_4;
		    *param1 = local_c;
		    return;
		  }
		  System_Activator__CreateInstance
		            (param3,Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06006F69 RID: 28521 RVA: 0x00014490 File Offset: 0x00012690
		[Token(Token = "0x170016C0")]
		public bool IsTargetSignin
		{
			[Token(Token = "0x6006F69")]
			[Address(RVA = "0x4889", Offset = "0x4889", VA = "0x4889")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x000144A8 File Offset: 0x000126A8
		[Token(Token = "0x6006F6A")]
		[Address(RVA = "0xB9D3", Offset = "0xB9D3", VA = "0xB9D3")]
		private UniTask<IPlatformSigninProvider> TrySignin(IPlatformSigninProvider provider)
		{
		/* --- GHIDRA: TrySignin ---
		void Core_Application_Managers_PlatformSigninManager__TrySignin
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0xc) = param2;
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return default(UniTask<IPlatformSigninProvider>);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6B")]
		[Address(RVA = "0xB9D4", Offset = "0xB9D4", VA = "0xB9D4")]
		private void CompleteSignin(IPlatformSigninProvider provider)
		{
		/* --- GHIDRA: CompleteSignin ---
		void Core_Application_Managers_PlatformSigninManager__CompleteSignin
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
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
		  
		  if (DAT_ram_00a5a846 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PlatformSigninManager__SigninToTargetProvider_d__25___
		              );
		    DAT_ram_00a5a846 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_PlatformSigninManager__Init_d__19_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PlatformSigninManager__SigninToTargetProvider_d__25___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6C")]
		[Address(RVA = "0xB9D5", Offset = "0xB9D5", VA = "0xB9D5")]
		public void SigninToTargetProvider(PlatformSigninProviderCallback callback)
		{
		/* --- GHIDRA: SigninToTargetProvider ---
		void Core_Application_Managers_PlatformSigninManager__SigninToTargetProvider
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5a847 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    DAT_ram_00a5a847 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  piVar4 = *(int **)(param1 + 0x14);
		  if (param1_00 == piVar4) {
		    iVar3 = *param1_00;
		    if (((uint)*(byte *)(iVar3 + 0xb8) <
		         (uint)*(byte *)(Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(iVar3 + 100) +
		                    (uint)*(byte *)(
		                                   Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Core_Application_Managers_AbstractPlatformSigninProvider_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00[4] = param2;
		    uVar1 = 0;
		    piVar4 = param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		          goto code_r0x8127cfdf;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Core_Application_Managers_IPlatformSigninProvider_TypeInfo,5);
		  }
		  else {
		    uVar1 = 0;
		    iVar3 = *piVar4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		          goto code_r0x8127cfdf;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,
		                                  6);
		  }
		code_r0x8127cfdf:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6D")]
		[Address(RVA = "0xB9D6", Offset = "0xB9D6", VA = "0xB9D6")]
		public void Commit(SigninRecord record)
		{
		/* --- GHIDRA: Commit ---
		void Core_Application_Managers_PlatformSigninManager__Commit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a848 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12414);
		    DAT_ram_00a5a848 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf8);
		          goto code_r0x8127d0a4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Core_Application_Managers_IPlatformSigninProvider_TypeInfo,7);
		code_r0x8127d0a4:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_12414,0);
		  return;
		}
		*/

		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6E")]
		[Address(RVA = "0xB9D7", Offset = "0xB9D7", VA = "0xB9D7")]
		public void ResetToDefaultProvider()
		{
		/* --- GHIDRA: ResetToDefaultProvider ---
		void Core_Application_Managers_PlatformSigninManager__ResetToDefaultProvider
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
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
		  
		  if (DAT_ram_00a5a849 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PlatformSigninManager__HandleDefaultSigninComplete_d__28___
		              );
		    DAT_ram_00a5a849 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param2;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___PlatformSigninManager__Init_d__19_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PlatformSigninManager__HandleDefaultSigninComplete_d__28___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0xB9D8", Offset = "0xB9D8", VA = "0xB9D8")]
		private void HandleDefaultSigninComplete(IPlatformSigninProvider provider)
		{
		/* --- GHIDRA: HandleDefaultSigninComplete ---
		void Core_Application_Managers_PlatformSigninManager__HandleDefaultSigninComplete
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined8 *)(param1 + 8) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F70")]
		[Address(RVA = "0x226A", Offset = "0x226A", VA = "0x226A")]
		private void HandleTargetSigninComplete(IPlatformSigninProvider provider)
		{
		/* --- GHIDRA: HandleTargetSigninComplete ---
		void Core_Application_Managers_PlatformSigninManager__HandleTargetSigninComplete
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5b81d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_SigninRecord_TypeInfo);
		    DAT_ram_00a5b81d = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  param1_00 = unnamed_function_1417(Core_Application_Managers_SigninRecord_TypeInfo);
		  func_ii_9113(param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = 0x6f;
		  param1[4] = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,2,*(undefined4 *)(*param1 + 300));
		  return;
		}
		*/

		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F71")]
		[Address(RVA = "0xB9D9", Offset = "0xB9D9", VA = "0xB9D9", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Application_Managers_PlatformSigninManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a84b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12413);
		    DAT_ram_00a5a84b = '\x01';
		  }
		  return StringLiteral_12413;
		}
		*/

		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C1")]
		public string Name
		{
			[Token(Token = "0x6006F72")]
			[Address(RVA = "0xB9DA", Offset = "0xB9DA", VA = "0xB9DA", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003A28 RID: 14888
		[Token(Token = "0x4003A28")]
		[FieldOffset(Offset = "0x10")]
		private IPlatformSigninProvider _targetProvider;

		// Token: 0x04003A29 RID: 14889
		[Token(Token = "0x4003A29")]
		[FieldOffset(Offset = "0x14")]
		private IPlatformSigninProvider _defaultProvider;

		// Token: 0x04003A2C RID: 14892
		[Token(Token = "0x4003A2C")]
		[FieldOffset(Offset = "0x20")]
		private PlatformSigninProviderCallback _callbackForTry;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TargetProvider ---
		void Core_Application_Managers_PlatformSigninManager__get_TargetProvider
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a840 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a840 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_PlatformSigninManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a841 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a841 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Application_Managers_PlatformSigninManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a842 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a842 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Application_Managers_PlatformSigninManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a843 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a843 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: get_IsTargetSignin ---
		void Core_Application_Managers_PlatformSigninManager__get_IsTargetSignin
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  undefined8 uVar6;
		  
		  uVar6 = param2;
		  if (DAT_ram_00a63b70 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass13_0__RunSetUserIdAfterSync_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass13_0_TypeInfo
		              );
		    DAT_ram_00a63b70 = '\x01';
		  }
		  uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass13_0_TypeInfo
		                    );
		  *(int **)(iVar2 + 0x10) = param1;
		  *(undefined8 *)(iVar2 + 8) = param2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104)));
		  param1_00 = *(int **)(iVar3 + 0x34);
		  uVar6 = *(undefined8 *)(iVar2 + 8);
		  uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,iVar2,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerController___c__DisplayClass13_0__RunSetUserIdAfterSync_b__0__
		             ,0);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8235ec84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Managers_ILoggedUserIdSetter_TypeInfo,0);
		code_r0x8235ec84:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar6,uVar4,puVar5[1]);
		  return;
		}
		*/

}
