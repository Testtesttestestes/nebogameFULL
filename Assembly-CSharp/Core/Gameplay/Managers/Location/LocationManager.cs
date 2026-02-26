using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Il2CppDummyDll;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Managers.Location
{
	// Token: 0x020011BD RID: 4541
	[Token(Token = "0x20011BD")]
	public class LocationManager : ILocation, IGameManager, IBaseManager
	{
		// Token: 0x140002C1 RID: 705
		// (add) Token: 0x06006BF5 RID: 27637 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006BF6 RID: 27638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C1")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006BF5")]
			[Address(RVA = "0xB6E4", Offset = "0xB6E4", VA = "0xB6E4", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006BF6")]
			[Address(RVA = "0xB6E5", Offset = "0xB6E5", VA = "0xB6E5", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002C2 RID: 706
		// (add) Token: 0x06006BF7 RID: 27639 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006BF8 RID: 27640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C2")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006BF7")]
			[Address(RVA = "0xB6E6", Offset = "0xB6E6", VA = "0xB6E6", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006BF8")]
			[Address(RVA = "0xB6E7", Offset = "0xB6E7", VA = "0xB6E7", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BFA RID: 27642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700160E")]
		public IGame Game
		{
			[Token(Token = "0x6006BF9")]
			[Address(RVA = "0xB6E8", Offset = "0xB6E8", VA = "0xB6E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006BFA")]
			[Address(RVA = "0xB6E9", Offset = "0xB6E9", VA = "0xB6E9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700160F")]
		public string Name
		{
			[Token(Token = "0x6006BFB")]
			[Address(RVA = "0xB6EA", Offset = "0xB6EA", VA = "0xB6EA", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BFC")]
		[Address(RVA = "0xB6EB", Offset = "0xB6EB", VA = "0xB6EB")]
		public LocationManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 HuaweiMobileServices_Location_LocationManager___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5eec7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7043);
		    DAT_ram_00a5eec7 = '\x01';
		  }
		  if (*(int *)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(HuaweiMobileServices_Location_LocationManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__GetStatic_long_
		                    (**(undefined4 **)
		                       (HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c),
		                     StringLiteral_7043,Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Location_LocationManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a6b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Location_LocationManager_CurrentIsleChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_LocationService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a6b0 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_LocationService___);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x8125713b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125713b:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,CONCAT44(in_register_20000014,puVar3[1]));
		  iVar6 = *(int *)(iVar5 + 0xc);
		  param1_01 = *(undefined4 *)(iVar6 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar2,param1,
		               Method_Core_Gameplay_Managers_Location_LocationManager_CurrentIsleChangedEvent__,0);
		  iVar5 = UnityEngine_UI_Image__set_sprite(param1_01,uVar2,0);
		  uVar2 = System_Action_ulong__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x1c) = 0;
		    Core_Gameplay_Managers_Location_LocationManager__ForwardLocation(param1,0,0);
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_ulong__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x1c) = iVar4;
		    uVar2 = System_Action_ulong__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_ulong__TypeInfo);
		    if (iVar6 != 0) {
		      Core_Gameplay_Managers_Location_LocationManager__ForwardLocation(param1,0,iVar5);
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BFD")]
		[Address(RVA = "0xB6EC", Offset = "0xB6EC", VA = "0xB6EC", Slot = "9")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Location_LocationManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Location_LocationManager_CurrentIsleChangedEvent__);
		    DAT_ram_00a5a6b1 = '\x01';
		  }
		  Utils_OpToken__Cancel(*(undefined4 *)(param1 + 0x1c),0);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x81257445;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81257445:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x812574c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,0xc);
		code_r0x812574c7:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  piVar5 = *(int **)(iVar6 + 0x28);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81257548;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,3)
		  ;
		code_r0x81257548:
		  uVar1 = 0;
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,0,puVar2[1]);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x812575cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x812575cd:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0xc);
		  param1_00 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar3,param1,
		               Method_Core_Gameplay_Managers_Location_LocationManager_CurrentIsleChangedEvent__,0);
		  iVar6 = func_ii_7048(param1_00,uVar3,0);
		  uVar3 = System_Action_ulong__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar3 = System_Action_ulong__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(undefined1 *)(param1 + 0x14) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar6 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		            (*(undefined4 *)(iVar6 + 0x20),param1,*(undefined4 *)(iVar6 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BFE")]
		[Address(RVA = "0xB6ED", Offset = "0xB6ED", VA = "0xB6ED", Slot = "10")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Location_LocationManager__Deinit
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined8 param3_00;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a6b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Location_LocationManager___c__DisplayClass18_0__ForwardLocation_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Location_LocationManager___c__DisplayClass18_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    DAT_ram_00a5a6b2 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_Location_LocationManager___c__DisplayClass18_0_TypeInfo
		                        );
		  uVar1 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  piVar3 = *(int **)(param2 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x81257777;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81257777:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = *(undefined4 *)(*(int *)(iVar4 + 0x14) + 0x1c);
		  uVar5 = 0;
		  piVar3 = *(int **)(param2 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x81257802;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81257802:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3_00 = Gameplay_World_Model_WorldModel__set_CurrentLocationType
		                        (*(undefined4 *)(iVar4 + 0x14),0);
		  uVar1 = ServicesNamespace_LocationService__get_ServiceId
		                    (*(undefined4 *)(param2 + 0x10),uVar1,param3_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Core_Gameplay_Managers_Location_LocationManager___c__DisplayClass18_0__ForwardLocation_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult
		            (&local_8,*(undefined4 *)(param2_00 + 8),0);
		  *param1 = local_8;
		  return;
		}
		*/

		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x00013FE0 File Offset: 0x000121E0
		[Token(Token = "0x6006BFF")]
		[Address(RVA = "0xB6EE", Offset = "0xB6EE", VA = "0xB6EE", Slot = "4")]
		public UniTask ForwardLocation()
		{
		/* --- GHIDRA: ForwardLocation ---
		void Core_Gameplay_Managers_Location_LocationManager__ForwardLocation
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  undefined8 param3_00;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a6b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Location_LocationManager_ChangeLocationSuccessHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a6b3 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x8125728e;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125728e:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		  uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x1c);
		  uVar5 = 0;
		  piVar2 = *(int **)(param1 + 0x18);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x81257319;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81257319:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		  param3_00 = Gameplay_World_Model_WorldModel__set_CurrentLocationType
		                        (*(undefined4 *)(iVar3 + 0x14),0);
		  uVar4 = ServicesNamespace_LocationService__get_ServiceId
		                    (*(undefined4 *)(param1 + 0x10),uVar4,param3_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Location_LocationManager_ChangeLocationSuccessHandler__,0
		            );
		  uVar4 = ServicesNamespace_MainService__GetUserStats
		                    (uVar4,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x1c),uVar4,0);
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C00")]
		[Address(RVA = "0xB6EF", Offset = "0xB6EF", VA = "0xB6EF")]
		private void CurrentIsleChangedEvent(ulong prevOwnerId = 0UL)
		{
		/* --- GHIDRA: CurrentIsleChangedEvent ---
		void Core_Gameplay_Managers_Location_LocationManager__CurrentIsleChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a6b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    DAT_ram_00a5a6b4 = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x1c),param2,0);
		  if (*(char *)(param1 + 0x14) == '\0') {
		    *(undefined1 *)(param1 + 0x14) = 1;
		    uVar1 = 0;
		    piVar3 = *(int **)(param1 + 0x18);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x81257943;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81257943:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		          goto code_r0x812579c5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xc);
		code_r0x812579c5:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    piVar3 = *(int **)(iVar4 + 0x28);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		          goto code_r0x81257a46;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,
		                                  3);
		code_r0x81257a46:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1,puVar2[1]);
		    iVar4 = *(int *)(param1 + 8);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C01")]
		[Address(RVA = "0xB6F0", Offset = "0xB6F0", VA = "0xB6F0")]
		private void ChangeLocationSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040038DB RID: 14555
		[Token(Token = "0x40038DB")]
		[FieldOffset(Offset = "0x10")]
		private LocationService _locationService;

		// Token: 0x040038DC RID: 14556
		[Token(Token = "0x40038DC")]
		[FieldOffset(Offset = "0x14")]
		private bool _isInitialized;

		// Token: 0x040038DE RID: 14558
		[Token(Token = "0x40038DE")]
		[FieldOffset(Offset = "0x1C")]
		private OpTokenRepository _tokenRepository;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Location_LocationManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6ab = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_Location_LocationManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6ac = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Location_LocationManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6ad = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: set_Game ---
		undefined4
		Core_Gameplay_Managers_Location_LocationManager__set_Game(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a6ae == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_10637);
		    DAT_ram_00a5a6ae = '\x01';
		  }
		  return StringLiteral_10637;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Location_LocationManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6af == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_OpTokenRepository_TypeInfo);
		    DAT_ram_00a5a6af = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = param2;
		  param1_00 = unnamed_function_1417(Utils_OpTokenRepository_TypeInfo);
		  Utils_OpTokenRepository__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: get_EXTRA_LOCATION_ENABLED ---
		undefined4
		HuaweiMobileServices_Location_LocationManager__get_EXTRA_LOCATION_ENABLED(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5eec8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7044);
		    DAT_ram_00a5eec8 = '\x01';
		  }
		  if (*(int *)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(HuaweiMobileServices_Location_LocationManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__GetStatic_long_
		                    (**(undefined4 **)
		                       (HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c),
		                     StringLiteral_7044,Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_EXTRA_PROVIDER_ENABLED ---
		undefined4
		HuaweiMobileServices_Location_LocationManager__get_EXTRA_PROVIDER_ENABLED(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5eec9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7045);
		    DAT_ram_00a5eec9 = '\x01';
		  }
		  if (*(int *)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(HuaweiMobileServices_Location_LocationManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__GetStatic_long_
		                    (**(undefined4 **)
		                       (HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c),
		                     StringLiteral_7045,Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_EXTRA_PROVIDER_NAME ---
		undefined4 HuaweiMobileServices_Location_LocationManager__get_EXTRA_PROVIDER_NAME(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5eeca == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8395);
		    DAT_ram_00a5eeca = '\x01';
		  }
		  if (*(int *)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(HuaweiMobileServices_Location_LocationManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__GetStatic_long_
		                    (**(undefined4 **)
		                       (HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c),
		                     StringLiteral_8395,Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_GPS_PROVIDER ---
		undefined4 HuaweiMobileServices_Location_LocationManager__get_GPS_PROVIDER(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5eecb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10201);
		    DAT_ram_00a5eecb = '\x01';
		  }
		  if (*(int *)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(HuaweiMobileServices_Location_LocationManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__GetStatic_long_
		                    (**(undefined4 **)
		                       (HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c),
		                     StringLiteral_10201,Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_KEY_LOCATION_CHANGED ---
		undefined4
		HuaweiMobileServices_Location_LocationManager__get_KEY_LOCATION_CHANGED(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5eecc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10203);
		    DAT_ram_00a5eecc = '\x01';
		  }
		  if (*(int *)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(HuaweiMobileServices_Location_LocationManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__GetStatic_long_
		                    (**(undefined4 **)
		                       (HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c),
		                     StringLiteral_10203,Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_KEY_PROVIDER_ENABLED ---
		undefined4
		HuaweiMobileServices_Location_LocationManager__get_KEY_PROVIDER_ENABLED(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5eecd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10204);
		    DAT_ram_00a5eecd = '\x01';
		  }
		  if (*(int *)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(HuaweiMobileServices_Location_LocationManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_AndroidJavaObject__GetStatic_long_
		                    (**(undefined4 **)
		                       (HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c),
		                     StringLiteral_10204,Method_UnityEngine_AndroidJavaObject_GetStatic_string___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_KEY_PROXIMITY_ENTERING ---
		void HuaweiMobileServices_Location_LocationManager__get_KEY_PROXIMITY_ENTERING(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5eece == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_AndroidJavaClass_TypeInfo);
		    Mono_Security_ASN1__get_Item(&HuaweiMobileServices_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19817);
		    DAT_ram_00a5eece = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_AndroidJavaClass_TypeInfo);
		  func_ii_8689(param1_00,StringLiteral_19817,0);
		  **(undefined4 **)(HuaweiMobileServices_Location_LocationManager_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

}
