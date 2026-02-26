using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Portal;
using UI.Tabs;
using Utils;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005CF RID: 1487
	[Token(Token = "0x20005CF")]
	public class PortalsModel : AbstractModel
	{
		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A5")]
		public PortalInfo PortalInfo
		{
			[Token(Token = "0x60023A0")]
			[Address(RVA = "0x74F2", Offset = "0x74F2", VA = "0x74F2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023A1")]
			[Address(RVA = "0x74F3", Offset = "0x74F3", VA = "0x74F3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A6")]
		public PortalMonsterData Monster
		{
			[Token(Token = "0x60023A2")]
			[Address(RVA = "0x74F4", Offset = "0x74F4", VA = "0x74F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023A3")]
			[Address(RVA = "0x74F5", Offset = "0x74F5", VA = "0x74F5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A7")]
		public PortalUserInfo UserInfo
		{
			[Token(Token = "0x60023A4")]
			[Address(RVA = "0x74F6", Offset = "0x74F6", VA = "0x74F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023A5")]
			[Address(RVA = "0x74F7", Offset = "0x74F7", VA = "0x74F7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A8")]
		public PortalMonsterInfo MonsterInfo
		{
			[Token(Token = "0x60023A6")]
			[Address(RVA = "0x74F8", Offset = "0x74F8", VA = "0x74F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023A7")]
			[Address(RVA = "0x74F9", Offset = "0x74F9", VA = "0x74F9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A9")]
		public PortalStageInfo PortalStageInfo
		{
			[Token(Token = "0x60023A8")]
			[Address(RVA = "0x74FA", Offset = "0x74FA", VA = "0x74FA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023A9")]
			[Address(RVA = "0x74FB", Offset = "0x74FB", VA = "0x74FB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006AA")]
		public IGame Game
		{
			[Token(Token = "0x60023AA")]
			[Address(RVA = "0x74FC", Offset = "0x74FC", VA = "0x74FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AB")]
		public BackTime StageBackTime
		{
			[Token(Token = "0x60023AB")]
			[Address(RVA = "0x74FD", Offset = "0x74FD", VA = "0x74FD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023AC")]
			[Address(RVA = "0x74FE", Offset = "0x74FE", VA = "0x74FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AC")]
		public BackTime PortalBackTime
		{
			[Token(Token = "0x60023AD")]
			[Address(RVA = "0x74FF", Offset = "0x74FF", VA = "0x74FF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023AE")]
			[Address(RVA = "0x7500", Offset = "0x7500", VA = "0x7500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AD")]
		public BackTime EntryPointBackTime
		{
			[Token(Token = "0x60023AF")]
			[Address(RVA = "0x7501", Offset = "0x7501", VA = "0x7501")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023B0")]
			[Address(RVA = "0x7502", Offset = "0x7502", VA = "0x7502")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x170006AE")]
		public ulong Balance
		{
			[Token(Token = "0x60023B1")]
			[Address(RVA = "0x7503", Offset = "0x7503", VA = "0x7503")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x170006AF")]
		public bool IsRegistered
		{
			[Token(Token = "0x60023B2")]
			[Address(RVA = "0x7504", Offset = "0x7504", VA = "0x7504")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x170006B0")]
		public bool HasPortal
		{
			[Token(Token = "0x60023B3")]
			[Address(RVA = "0x7505", Offset = "0x7505", VA = "0x7505")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x170006B1")]
		public bool HasPortalAndUser
		{
			[Token(Token = "0x60023B4")]
			[Address(RVA = "0x7506", Offset = "0x7506", VA = "0x7506")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x170006B2")]
		public bool IsCombatAvailable
		{
			[Token(Token = "0x60023B5")]
			[Address(RVA = "0x7507", Offset = "0x7507", VA = "0x7507")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x00006F30 File Offset: 0x00005130
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B3")]
		public PortalsTargets LastPortalsTarget
		{
			[Token(Token = "0x60023B6")]
			[Address(RVA = "0x7508", Offset = "0x7508", VA = "0x7508")]
			[CompilerGenerated]
			get
			{
				return PortalsTargets.None;
			}
			[Token(Token = "0x60023B7")]
			[Address(RVA = "0x7509", Offset = "0x7509", VA = "0x7509")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x170006B4")]
		public int PortalsTargetsCount
		{
			[Token(Token = "0x60023B8")]
			[Address(RVA = "0x750A", Offset = "0x750A", VA = "0x750A")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B5")]
		public PortalDic CurrentPortalDic
		{
			[Token(Token = "0x60023B9")]
			[Address(RVA = "0x750B", Offset = "0x750B", VA = "0x750B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023BA")]
			[Address(RVA = "0x750C", Offset = "0x750C", VA = "0x750C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023BC RID: 9148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B6")]
		public PortalStageDic CurrentPortalStageDic
		{
			[Token(Token = "0x60023BB")]
			[Address(RVA = "0x750D", Offset = "0x750D", VA = "0x750D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023BC")]
			[Address(RVA = "0x750E", Offset = "0x750E", VA = "0x750E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B7")]
		public PortalStageDic PrevPortalStageDic
		{
			[Token(Token = "0x60023BD")]
			[Address(RVA = "0x750F", Offset = "0x750F", VA = "0x750F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023BE")]
			[Address(RVA = "0x7510", Offset = "0x7510", VA = "0x7510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023C0 RID: 9152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B8")]
		public ResourceSet CurrentBetPool
		{
			[Token(Token = "0x60023BF")]
			[Address(RVA = "0x7511", Offset = "0x7511", VA = "0x7511")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023C0")]
			[Address(RVA = "0x7512", Offset = "0x7512", VA = "0x7512")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B9")]
		public ResourceSet CurrentJackpot
		{
			[Token(Token = "0x60023C1")]
			[Address(RVA = "0x7513", Offset = "0x7513", VA = "0x7513")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023C2")]
			[Address(RVA = "0x7514", Offset = "0x7514", VA = "0x7514")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x7515", Offset = "0x7515", VA = "0x7515")]
		public TabBarItemData[] GetTabBarItemData()
		{
		/* --- GHIDRA: GetTabBarItemData ---
		void Gameplay_Portals_Model_PortalsModel__GetTabBarItemData
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  
		  if (DAT_ram_00a58123 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsTargets_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a58123 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  *(undefined4 *)(param1 + 0x34) = 1;
		  *(undefined4 *)(param1 + 0x30) = uVar2;
		  uVar2 = Gameplay_Portals_Model_PortalsTargets_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar2 = func_ii_2734(uVar2,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar3 = System_Enum__InternalGetValues(uVar2,0);
		  *(undefined4 *)(param1 + 0x38) = *(undefined4 *)(iVar3 + 0xc);
		  uVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(undefined4 *)(param1 + 0x48) = uVar2;
		  uVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(undefined4 *)(param1 + 0x4c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(int **)(param1 + 0x24) = param3;
		  iVar3 = *param3;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x80ea5c61;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ea5c61:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param3,puVar4[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x7516", Offset = "0x7516", VA = "0x7516")]
		public PortalsModel(UserData user, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Model_PortalsModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int param3_00;
		  int iVar2;
		  
		  *(int *)(param1 + 0x20) = param2;
		  if (param2 != 0) {
		    param3_00 = *(int *)(param2 + 0x18);
		    iVar2 = *(int *)(param3_00 + 0xc);
		    if (iVar2 != 0) {
		      if (iVar2 != 1) {
		        if (iVar2 != 2) {
		          uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		          uVar1 = unnamed_function_1417(uVar1);
		          System_ArgumentNullException___ctor(uVar1,0);
		          param2_00 = unnamed_function_2232
		                                (&Method_Gameplay_Portals_Model_PortalsModel_SetPortalStageInfo__);
		          func_ii_1050(uVar1,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        Gameplay_Portals_Model_PortalsModel__SetPortalStageInfo
		                  (param1,*(undefined8 *)(param3_00 + 0x10),param3_00);
		        Gameplay_Portals_Model_PortalsModel__SetStageBackTime
		                  (param1,*(undefined8 *)(*(int *)(*(int *)(param1 + 0x20) + 0x18) + 0x10),param3_00
		                  );
		        return;
		      }
		      Gameplay_Portals_Model_PortalsModel__SetPortalStageInfo
		                (param1,*(undefined8 *)(param3_00 + 0x10),param3_00);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x7517", Offset = "0x7517", VA = "0x7517")]
		public void SetPortalStageInfo(PortalStageInfo portalStageInfo)
		{
		/* --- GHIDRA: SetPortalStageInfo ---
		void Gameplay_Portals_Model_PortalsModel__SetPortalStageInfo
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float param2_00;
		  
		  if (DAT_ram_00a58124 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58124 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(param2,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x7518", Offset = "0x7518", VA = "0x7518")]
		public void SetStageBackTime(ulong milliseconds)
		{
		/* --- GHIDRA: SetStageBackTime ---
		void Gameplay_Portals_Model_PortalsModel__SetStageBackTime
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float param2_00;
		  
		  if (DAT_ram_00a58125 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58125 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(param2,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x7519", Offset = "0x7519", VA = "0x7519")]
		private void SetPortalBackTime(ulong milliseconds)
		{
		/* --- GHIDRA: SetPortalBackTime ---
		void Gameplay_Portals_Model_PortalsModel__SetPortalBackTime
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float param2_00;
		  
		  if (DAT_ram_00a58126 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58126 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(param2,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x751A", Offset = "0x751A", VA = "0x751A")]
		public void SetEntryPointBackTime(ulong milliseconds)
		{
		}

		// Token: 0x040013A8 RID: 5032
		[Token(Token = "0x40013A8")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_EntryPointBackTime ---
		undefined8 Gameplay_Portals_Model_PortalsModel__set_EntryPointBackTime(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x18) != 0) {
		    return *(undefined8 *)(*(int *)(param1 + 0x18) + 0x10);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_HasPortal ---
		uint Gameplay_Portals_Model_PortalsModel__get_HasPortal(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x10) != 0) {
		    return (uint)(*(int *)(param1 + 0x18) != 0);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_HasPortalAndUser ---
		uint Gameplay_Portals_Model_PortalsModel__get_HasPortalAndUser(int param1,undefined4 param2)
		
		{
		  return (uint)(*(ulonglong *)(*(int *)(param1 + 0x18) + 0x20) ==
		               (ulonglong)*(uint *)(*(int *)(param1 + 0x20) + 0xc));
		}
		*/


		/* --- GHIDRA: set_CurrentJackpot ---
		int * Gameplay_Portals_Model_PortalsModel__set_CurrentJackpot(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58122 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_PortalsTargets____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_PortalsTargets___ctor__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_PortalsTargets__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12146);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12148);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12150);
		    DAT_ram_00a58122 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (UI_Tabs_TabBarItemData_PortalsTargets____TypeInfo,4);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12146,1,0,1,0,0,0,0);
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_PortalsTargets__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (iVar3,uVar2,1,Method_UI_Tabs_TabBarItemData_PortalsTargets___ctor__);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20)), iVar4 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = iVar3;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12152,1,0,1,0,0,0,0);
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_PortalsTargets__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (iVar3,uVar2,2,Method_UI_Tabs_TabBarItemData_PortalsTargets___ctor__);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20)), iVar4 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[5] = iVar3;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12148,1,0,1,0,0,0,0);
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_PortalsTargets__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (iVar3,uVar2,3,Method_UI_Tabs_TabBarItemData_PortalsTargets___ctor__);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20)), iVar4 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[6] = iVar3;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12150,1,0,1,0,0,0,0);
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_PortalsTargets__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (iVar3,uVar2,4,Method_UI_Tabs_TabBarItemData_PortalsTargets___ctor__);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20)), iVar4 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[7] = iVar3;
		  return piVar1;
		}
		*/

}
