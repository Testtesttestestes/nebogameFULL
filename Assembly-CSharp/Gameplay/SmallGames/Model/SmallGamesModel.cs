using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.SmallGames;
using Utils;

namespace Gameplay.SmallGames.Model
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	public class SmallGamesModel : AbstractModel
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CB")]
		public FreeAttemptsInfo FreeAttemptsDiamond
		{
			[Token(Token = "0x6001FB0")]
			[Address(RVA = "0x7115", Offset = "0x7115", VA = "0x7115")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CC")]
		public FreeAttemptsInfo FreeAttemptsOnyx
		{
			[Token(Token = "0x6001FB1")]
			[Address(RVA = "0x7116", Offset = "0x7116", VA = "0x7116")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x000066A8 File Offset: 0x000048A8
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CD")]
		public uint LastScrollCount
		{
			[Token(Token = "0x6001FB2")]
			[Address(RVA = "0x7117", Offset = "0x7117", VA = "0x7117")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FB3")]
			[Address(RVA = "0x7118", Offset = "0x7118", VA = "0x7118")]
			set
			{
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CE")]
		public bool HasDrop
		{
			[Token(Token = "0x6001FB4")]
			[Address(RVA = "0x7119", Offset = "0x7119", VA = "0x7119")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FB5")]
			[Address(RVA = "0x711A", Offset = "0x711A", VA = "0x711A")]
			private set
			{
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000066D8 File Offset: 0x000048D8
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CF")]
		public SlotMachineType CurrentSlotMachineType
		{
			[Token(Token = "0x6001FB6")]
			[Address(RVA = "0x711B", Offset = "0x711B", VA = "0x711B")]
			[CompilerGenerated]
			get
			{
				return SlotMachineType.UnknownMachine;
			}
			[Token(Token = "0x6001FB7")]
			[Address(RVA = "0x711C", Offset = "0x711C", VA = "0x711C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D0")]
		public ProtoLaunchWheelsAns WheelResult
		{
			[Token(Token = "0x6001FB8")]
			[Address(RVA = "0x711D", Offset = "0x711D", VA = "0x711D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FB9")]
			[Address(RVA = "0x711E", Offset = "0x711E", VA = "0x711E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D1")]
		public ResourceSet Jackpot
		{
			[Token(Token = "0x6001FBA")]
			[Address(RVA = "0x711F", Offset = "0x711F", VA = "0x711F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FBB")]
			[Address(RVA = "0x7120", Offset = "0x7120", VA = "0x7120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D2")]
		public int RewardNotificationsCount
		{
			[Token(Token = "0x6001FBC")]
			[Address(RVA = "0x7121", Offset = "0x7121", VA = "0x7121")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FBD")]
			[Address(RVA = "0x7122", Offset = "0x7122", VA = "0x7122")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D3")]
		public SlotMachineDic CurrentSlotMachineDic
		{
			[Token(Token = "0x6001FBE")]
			[Address(RVA = "0x7123", Offset = "0x7123", VA = "0x7123")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D4")]
		public FreeAttemptsInfo CurrentFreeAttempts
		{
			[Token(Token = "0x6001FBF")]
			[Address(RVA = "0x7124", Offset = "0x7124", VA = "0x7124")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D5")]
		public BackTime CurrentBacktime
		{
			[Token(Token = "0x6001FC0")]
			[Address(RVA = "0x7125", Offset = "0x7125", VA = "0x7125")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x170005D6")]
		public Resources CurrentResource
		{
			[Token(Token = "0x6001FC1")]
			[Address(RVA = "0x7126", Offset = "0x7126", VA = "0x7126")]
			get
			{
				return Resources.UnknownResource;
			}
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x7127", Offset = "0x7127", VA = "0x7127")]
		public BackTime GetCurrentBacktime(SlotMachineType slotMachineType)
		{
		/* --- GHIDRA: GetCurrentBacktime ---
		void Gameplay_SmallGames_Model_SmallGamesModel__GetCurrentBacktime(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a582ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___Clear__);
		    DAT_ram_00a582ad = '\x01';
		  }
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  iVar1 = *(int *)(param1 + 0x18);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___Clear__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x7128", Offset = "0x7128", VA = "0x7128", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_SmallGames_Model_SmallGamesModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a582ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_SlotMachineType__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_SlotMachineType__BackTime__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_FreeAttemptsInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ValueTuple_uint__ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SlotMachineDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&uint___TypeInfo);
		    DAT_ram_00a582ae = '\x01';
		  }
		  iVar2 = Mono_Security_ASN1Convert__ToOid(uint___TypeInfo,2);
		  *(undefined8 *)(iVar2 + 0x10) = 0x500000001;
		  *(int *)(param1 + 0xc) = iVar2;
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_List_ValueTuple_uint__ArtifactData___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar3,Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData____ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,
		             Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_SlotMachineType__uint__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_SlotMachineType__uint___ctor__);
		  System_Collections_Generic_Dictionary_Int32Enum__uint____ctor
		            (uVar3,1,1,Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__Add__);
		  System_Collections_Generic_Dictionary_Int32Enum__uint____ctor
		            (uVar3,2,1,Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__Add__);
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  uVar3 = unnamed_function_1417(Protocol_SmallGames_FreeAttemptsInfo_TypeInfo);
		  *(undefined4 *)(param1 + 0x2c) = uVar3;
		  uVar3 = unnamed_function_1417(Protocol_SmallGames_FreeAttemptsInfo_TypeInfo);
		  *(undefined4 *)(param1 + 0x30) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_SlotMachineType__BackTime__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime___ctor__);
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,0.0,0);
		  func_ii_10812(uVar3,1,uVar4,
		                Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__Add__);
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,0.0,0);
		  func_ii_10812(uVar3,2,uVar4,
		                Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__Add__);
		  *(undefined4 *)(param1 + 0x44) = 0xffffffff;
		  *(undefined4 *)(param1 + 0x38) = 1;
		  *(undefined4 *)(param1 + 0x34) = uVar3;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0x14) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80ec6bfe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ec6bfe:
		  uVar3 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,
		             Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic___ctor__);
		  uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x140),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_SlotMachineDic__get_Item__);
		  func_ii_10812(uVar3,1,uVar4,
		                Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__Add__)
		  ;
		  uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x140),1,
		                     Method_Google_Protobuf_Collections_RepeatedField_SlotMachineDic__get_Item__);
		  func_ii_10812(uVar3,2,uVar4,
		                Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__Add__)
		  ;
		  *(undefined4 *)(param1 + 0x24) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,
		             Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic____ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x7129", Offset = "0x7129", VA = "0x7129")]
		public SmallGamesModel(SmallGamesModel.DailyRewardsInfo dailyRewards, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_Model_SmallGamesModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int iVar9;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a582af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__WinCombinationDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__WinCombinationDic__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__WinCombinationDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_WinCombinationDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_WinCombinationDic__GetEnumerator__)
		    ;
		    DAT_ram_00a582af = '\x01';
		  }
		  iVar8 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a582b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_ProtoRegisterVisitAns_Types_DailyRewards___);
		    DAT_ram_00a582b6 = '\x01';
		  }
		  *(int *)(iVar8 + 8) = param2;
		  iVar9 = *(int *)(iVar8 + 0x10);
		  if (iVar9 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		              (*(undefined4 *)(iVar9 + 0x20),*(undefined4 *)(iVar9 + 0x14));
		    param2 = *(int *)(iVar8 + 8);
		  }
		  uVar2 = func_ii_6295(*(undefined4 *)(param2 + 0x24),
		                       Method_System_Linq_Enumerable_ToArray_ProtoRegisterVisitAns_Types_DailyRewards___
		                      );
		  *(undefined4 *)(iVar8 + 0xc) = uVar2;
		  uVar3 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 8),0);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x98),
		                              Method_Google_Protobuf_Collections_RepeatedField_WinCombinationDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar6 = local_4;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80ec6e61;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec6ea9:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ec7157;
		      }
		code_r0x80ec6e61:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ec6ea9;
		      if (iVar8 == 0) {
		        iVar8 = 0;
		        goto code_r0x80ec71a0;
		      }
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_WinCombinationDic__TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80ec6f54;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_WinCombinationDic__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec7098:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ec7157;
		      }
		code_r0x80ec6f54:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ec7098;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13d,
		                         *(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar8 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___ContainsKey__
		                        );
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ec7157;
		      }
		      if (iVar5 == 0) {
		        param3_00 = *(undefined4 *)(iVar8 + 0xc);
		        param2_00 = *(undefined4 *)(param1 + 0x1c);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_Dictionary_uint__WinCombinationDic__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x225,uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__WinCombinationDic___ctor__);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13e,param2_00,param3_00,
		                       uVar2,
		                       Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___set_Item__
		                      );
		            if (DAT_ram_009d3e38 != 1) goto code_r0x80ec708b;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ec7157;
		      }
		code_r0x80ec708b:
		    } while ((uVar3 < *(uint *)(iVar8 + 0x14)) || (*(uint *)(iVar8 + 0x18) < uVar3));
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,
		                       *(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar8 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_SlotMachineType__Dictionary_uint__WinCombinationDic___get_Item__
		                      );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec7157;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar2,
		               *(undefined4 *)(iVar8 + 0x10),iVar8,
		               Method_System_Collections_Generic_Dictionary_uint__WinCombinationDic__set_Item__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ec7157:
		  iVar8 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar9) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80ec71a0:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar3 = 0;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8)) {
		              puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80ec7218;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar3);
		        }
		        puVar7 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ec7218:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13f,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x712A", Offset = "0x712A", VA = "0x712A")]
		public void PopulateModel(ProtoRegisterVisitAns msg)
		{
		/* --- GHIDRA: PopulateModel ---
		void Gameplay_SmallGames_Model_SmallGamesModel__PopulateModel
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a582b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_Model_SmallGamesModel_JackpotInfo_TypeInfo);
		    DAT_ram_00a582b0 = '\x01';
		  }
		  if (*(int *)(param3 + 0x10) != 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417
		                          (Gameplay_SmallGames_Model_SmallGamesModel_JackpotInfo_TypeInfo);
		    param3_00 = 2;
		    if (param2 != 1) {
		      param3_00 = 4;
		    }
		    Gameplay_SmallGames_Model_SmallGamesModel__GetResourceId(param1_00,param3,param3_00,param3);
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (param1_01,param2,param1_00,
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__set_Item__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x712B", Offset = "0x712B", VA = "0x712B")]
		public void SetLastJackpot(SlotMachineType type, ProtoGetLastJackpotInfoAns msg)
		{
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x712C", Offset = "0x712C", VA = "0x712C")]
		public void SetJackpot(ResourceSet jackpot)
		{
		/* --- GHIDRA: SetJackpot ---
		void Gameplay_SmallGames_Model_SmallGamesModel__SetJackpot
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  float param2_00;
		  int *piVar2;
		  
		  if (DAT_ram_00a582b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a582b1 = '\x01';
		  }
		  if (param3 == 1) {
		    piVar2 = (int *)(param1 + 0x2c);
		  }
		  else {
		    if (param3 != 2) goto code_r0x80ec7631;
		    piVar2 = (int *)(param1 + 0x30);
		  }
		  *piVar2 = param2;
		code_r0x80ec7631:
		  param1_00 = GAFInternal_Reader_GAFReader__OpenTag
		                        (*(undefined4 *)(param1 + 0x34),param3,
		                         Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                        );
		  uVar1 = *(uint *)(param2 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)uVar1,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x712D", Offset = "0x712D", VA = "0x712D")]
		public void SetFreeAttempts(FreeAttemptsInfo freeAttempts, SlotMachineType type)
		{
		/* --- GHIDRA: SetFreeAttempts ---
		/* WARNING: Removing unreachable block (ram,0x80ec7daf) */
		
		void Gameplay_SmallGames_Model_SmallGamesModel__SetFreeAttempts
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param2_00;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  uint uVar9;
		  undefined8 local_48;
		  undefined8 local_40;
		  int local_38;
		  undefined8 *puStack_34;
		  undefined8 local_30;
		  int local_28;
		  int **local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  int *local_c;
		  undefined8 local_8;
		  
		  uVar9 = 0;
		  if (DAT_ram_00a582b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_InventoryMetaFilterData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_uint__ArtifactData___ctor__);
		    DAT_ram_00a582b2 = '\x01';
		  }
		  local_c = (int *)0x0;
		  local_18 = 0;
		  local_20 = 0;
		  iVar6 = param1;
		  if (param2 != (int *)0x0) {
		    iVar7 = *param2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_ArtifactData__TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		          puVar1 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80ec7790;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_ArtifactData__TypeInfo,0);
		code_r0x80ec7790:
		    iVar7 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		    uVar9 = (uint)(0 < iVar7);
		    if (param2 == (int *)0x0) {
		      iVar6 = 0;
		    }
		  }
		  *(char *)(*(int *)(*(int *)(iVar6 + 0x14) + 8) + 0x1c) = (char)uVar9;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x80ec7851;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ec7851:
		  iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		  param2_00 = Gameplay_Inventory_Model_InventoryBaseModel___ctor(*(undefined4 *)(iVar6 + 0x10),0);
		  iVar6 = *(int *)(param1 + 0x18);
		  iVar7 = *(int *)(iVar6 + 0xc);
		  *(undefined4 *)(iVar6 + 0xc) = 0;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  if (0 < iVar7) {
		    func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar7,0);
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ec7915;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo
		                                ,0);
		code_r0x80ec7915:
		  local_c = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  local_28 = 0;
		  local_24 = &local_c;
		  do {
		    piVar5 = local_c;
		    iVar6 = *local_c;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80ec79e3;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec7e49:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		      goto code_r0x80ec7e58;
		    }
		code_r0x80ec79e3:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_c;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ec7e49;
		    if (iVar6 == 0) goto code_r0x80ec7e9f;
		    iVar6 = *local_c;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		        if (System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80ec7ad0;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                        System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec7cce:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		      goto code_r0x80ec7e58;
		    }
		code_r0x80ec7ad0:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ec7cce;
		    *(undefined4 *)(iVar6 + 0x70) = *(undefined4 *)(param1 + 8);
		    uVar4 = *(undefined4 *)(*(int *)(iVar6 + 0xc) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_38,param2_00,
		               Method_System_Collections_Generic_List_InventoryMetaFilterData__GetEnumerator__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		      goto code_r0x80ec7e58;
		    }
		    local_18 = local_30;
		    local_20 = CONCAT44(puStack_34,local_38);
		    local_38 = 0;
		    puStack_34 = &local_20;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                         Method_System_Collections_Generic_List_Enumerator_InventoryMetaFilterData__MoveNext__
		                        );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ec7d31;
		      if (iVar7 == 0) goto code_r0x80ec7d83;
		      iVar7 = local_18._4_4_;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                         *(undefined4 *)(local_18._4_4_ + 0x14),uVar4,
		                         Method_System_Collections_Generic_Dictionary_uint__ArtikulTypeFilters__ContainsKey__
		                        );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ec7d31;
		    } while (iVar3 == 0);
		    iVar3 = *(int *)(param1 + 0x18);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(iVar7,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec7d31:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar7) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_38 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) goto code_r0x80ec7d83;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar6 = global_1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x142,&local_38);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) goto code_r0x80ec7e58;
		      goto code_r0x80ec7f71;
		    }
		    local_40 = 0;
		    DAT_ram_009d3e38 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_40,uVar4,iVar6,Method_System_ValueTuple_uint__ArtifactData___ctor__);
		    iVar6 = Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ec7d31;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar3 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar9 + 1;
		      *(undefined8 *)(*(int *)(iVar3 + 8) + uVar9 * 8 + 0x10) = local_40;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      local_48 = local_40;
		      local_8 = local_40;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x22f,iVar3,&local_48,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ec7d31;
		    }
		code_r0x80ec7d83:
		  } while (local_38 == 0);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_38);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar6 = global_1;
		code_r0x80ec7e58:
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar6) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_28 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80ec7e9f:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = *local_24;
		      if (piVar5 != (int *)0x0) {
		        uVar9 = 0;
		        iVar6 = *piVar5;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		              puVar1 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80ec7f1a;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80ec7f1a:
		        (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		      }
		      if (local_28 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_28);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x143,&local_28);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80ec7f71:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x712E", Offset = "0x712E", VA = "0x712E")]
		public void SetLastDrop(IList<ArtifactData> artifacts)
		{
		/* --- GHIDRA: SetLastDrop ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__SetLastDrop(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x2c;
		  if (param2 != 1) {
		    iVar1 = 0x30;
		  }
		  return *(undefined4 *)(*(int *)(param1 + iVar1) + 0xc);
		}
		*/

		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x712F", Offset = "0x712F", VA = "0x712F")]
		public uint GetFreeAttempts(SlotMachineType type)
		{
		/* --- GHIDRA: GetFreeAttempts ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__GetFreeAttempts
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 2;
		  if (param2 != 1) {
		    uVar1 = 4;
		  }
		  return uVar1;
		}
		*/

			return 0U;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x7130", Offset = "0x7130", VA = "0x7130")]
		public Resources GetResourceId(SlotMachineType type)
		{
		/* --- GHIDRA: GetResourceId ---
		void Gameplay_SmallGames_Model_SmallGamesModel__GetResourceId
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  double param2_00;
		  int *piVar4;
		  int iVar5;
		  undefined8 uVar6;
		  uint uVar7;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a582b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22543);
		    DAT_ram_00a582b3 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(undefined4 *)(param1 + 8) = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x18);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar1 = Utils_MathUtils_MathUtils__SaferDivide(param3,0);
		  param2_00 = func_ii_6906(*(undefined4 *)(param2 + 0x20),param3,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Data_ArtifactData__get_SellPrice(uVar1,param2_00,0);
		  uVar1 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x80ec74b6;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80ec74b6:
		  uVar6 = CONCAT44(uVar1,puVar3[1]);
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar6);
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar7 = 0;
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  piVar4 = *(int **)(iVar5 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8))
		      {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ec7542;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80ec7542:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,CONCAT44(uVar1,uVar2),puVar3[1]);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar6 = *(undefined8 *)(param2 + 0x18);
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  System_DateTimeOffset__FromUnixTimeSeconds(&local_20,uVar6,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  System_DateTimeOffset__ParseExact(&local_30,&local_10,0);
		  local_8 = local_28;
		  local_10 = local_30;
		  uVar1 = System_DateTimeOffset__ToString(&local_10,StringLiteral_22543,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

			return Resources.UnknownResource;
		}

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint[] BonusUserAccountIds;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0x10")]
		public readonly Dictionaries Dict;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x14")]
		public readonly SmallGamesModel.DailyRewardsInfo DailyRewards;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x18")]
		[TupleElementNames(new string[]
		{
			"SortOrder",
			"ArtifactData"
		})]
		public List<ValueTuple<uint, ArtifactData>> ArtifactsWithSortOrders;

		// Token: 0x0400116E RID: 4462
		[Token(Token = "0x400116E")]
		[FieldOffset(Offset = "0x1C")]
		public Dictionary<SlotMachineType, Dictionary<uint, WinCombinationDic>> WinCombinationsBySlotMachineByCombinationId;

		// Token: 0x0400116F RID: 4463
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<SlotMachineType, SmallGamesModel.JackpotInfo> LastJackpots;

		// Token: 0x04001170 RID: 4464
		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<SlotMachineType, SlotMachineDic> _slotMachineDicts;

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<SlotMachineType, uint> _scrollCountsBySlotMachine;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x2C")]
		private FreeAttemptsInfo _freeAttemptsDiamond;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x30")]
		private FreeAttemptsInfo _freeAttemptsOnyx;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x34")]
		public Dictionary<SlotMachineType, BackTime> FreeSpinsBacktimeByType;

		// Token: 0x02000536 RID: 1334
		[Token(Token = "0x2000536")]
		public class JackpotInfo
		{
			// Token: 0x06001FCC RID: 8140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001FCC")]
			[Address(RVA = "0x7131", Offset = "0x7131", VA = "0x7131")]
			public JackpotInfo(ProtoGetLastJackpotInfoAns msg, Resources resourceId)
			{
			}

			// Token: 0x04001179 RID: 4473
			[Token(Token = "0x4001179")]
			[FieldOffset(Offset = "0x8")]
			public string Nickname;

			// Token: 0x0400117A RID: 4474
			[Token(Token = "0x400117A")]
			[FieldOffset(Offset = "0xC")]
			public Money Resources;

			// Token: 0x0400117B RID: 4475
			[Token(Token = "0x400117B")]
			[FieldOffset(Offset = "0x10")]
			public UserData User;

			// Token: 0x0400117C RID: 4476
			[Token(Token = "0x400117C")]
			[FieldOffset(Offset = "0x14")]
			public string DateString;
		}

		// Token: 0x02000537 RID: 1335
		[Token(Token = "0x2000537")]
		public class DailyRewardsInfo
		{
			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005D7")]
			public ProtoRegisterVisitAns RegisterVisitAns
			{
				[Token(Token = "0x6001FCD")]
				[Address(RVA = "0x7132", Offset = "0x7132", VA = "0x7132")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001FCE")]
				[Address(RVA = "0x7133", Offset = "0x7133", VA = "0x7133")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00006750 File Offset: 0x00004950
			[Token(Token = "0x170005D8")]
			public bool CanTakeAdditional
			{
				[Token(Token = "0x6001FCF")]
				[Address(RVA = "0x7134", Offset = "0x7134", VA = "0x7134")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1400013C RID: 316
			// (add) Token: 0x06001FD0 RID: 8144 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1400013C")]
			public event Action DailyRewardsStatusChangedEvent
			{
				[Token(Token = "0x6001FD0")]
				[Address(RVA = "0x7135", Offset = "0x7135", VA = "0x7135")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6001FD1")]
				[Address(RVA = "0x7136", Offset = "0x7136", VA = "0x7136")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00006768 File Offset: 0x00004968
			// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005D9")]
			public ProtoRegisterVisitAns.Types.RegisterVisitStatus Status
			{
				[Token(Token = "0x6001FD2")]
				[Address(RVA = "0x7137", Offset = "0x7137", VA = "0x7137")]
				get
				{
					return ProtoRegisterVisitAns.Types.RegisterVisitStatus.BonusNotTaken;
				}
				[Token(Token = "0x6001FD3")]
				[Address(RVA = "0x7138", Offset = "0x7138", VA = "0x7138")]
				set
				{
				}
			}

			// Token: 0x06001FD4 RID: 8148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x7139", Offset = "0x7139", VA = "0x7139")]
			public void Init(ProtoRegisterVisitAns registerVisitAns)
			{
			}

			// Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x713A", Offset = "0x713A", VA = "0x713A")]
			public DailyRewardsInfo()
			{
			}

			// Token: 0x0400117E RID: 4478
			[Token(Token = "0x400117E")]
			[FieldOffset(Offset = "0xC")]
			public ProtoRegisterVisitAns.Types.DailyRewards[] DailyRewards;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_FreeAttemptsOnyx ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__get_FreeAttemptsOnyx(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a582a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__);
		    DAT_ram_00a582a9 = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(param1 + 0x38),
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__get_Item__)
		  ;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_LastScrollCount ---
		void Gameplay_SmallGames_Model_SmallGamesModel__get_LastScrollCount
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a582aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__set_Item__);
		    DAT_ram_00a582aa = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__uint___get_Values
		            (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(param1 + 0x38),param2,
		             Method_System_Collections_Generic_Dictionary_SlotMachineType__uint__set_Item__);
		  return;
		}
		*/


		/* --- GHIDRA: set_LastScrollCount ---
		uint Gameplay_SmallGames_Model_SmallGamesModel__set_LastScrollCount(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x1c);
		}
		*/


		/* --- GHIDRA: get_HasDrop ---
		void Gameplay_SmallGames_Model_SmallGamesModel__get_HasDrop
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x1c) = (undefined1)param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_RewardNotificationsCount ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__set_RewardNotificationsCount
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a582ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		              );
		    DAT_ram_00a582ab = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x38),
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__SlotMachineDic__get_Item__
		                    );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_CurrentSlotMachineDic ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__get_CurrentSlotMachineDic(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x2c;
		  if (*(int *)(param1 + 0x38) != 1) {
		    iVar1 = 0x30;
		  }
		  return *(undefined4 *)(param1 + iVar1);
		}
		*/


		/* --- GHIDRA: get_CurrentFreeAttempts ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__get_CurrentFreeAttempts(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = *(undefined4 *)(param1 + 0x38);
		  if (DAT_ram_00a582ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__);
		    DAT_ram_00a582ac = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x34),uVar1,
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                    );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_CurrentBacktime ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__get_CurrentBacktime(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 2;
		  if (*(int *)(param1 + 0x38) != 1) {
		    uVar1 = 4;
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_CurrentResource ---
		undefined4
		Gameplay_SmallGames_Model_SmallGamesModel__get_CurrentResource
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a582ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__);
		    DAT_ram_00a582ac = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x34),param2,
		                     Method_System_Collections_Generic_Dictionary_SlotMachineType__BackTime__get_Item__
		                    );
		  return uVar1;
		}
		*/

}
