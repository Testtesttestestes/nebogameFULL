using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Dic;
using Utils;

namespace Gameplay.Clans.ClanWars.Model
{
	// Token: 0x02000AA6 RID: 2726
	[Token(Token = "0x2000AA6")]
	public class ClanWarsModel : AbstractModel
	{
		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CEC")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60041AD")]
			[Address(RVA = "0x9061", Offset = "0x9061", VA = "0x9061")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CED")]
		public ClanWarInfo WarInfo
		{
			[Token(Token = "0x60041AE")]
			[Address(RVA = "0x9062", Offset = "0x9062", VA = "0x9062")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041AF")]
			[Address(RVA = "0x9063", Offset = "0x9063", VA = "0x9063")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEE")]
		public BackTime WarStateBacktime
		{
			[Token(Token = "0x60041B0")]
			[Address(RVA = "0x9064", Offset = "0x9064", VA = "0x9064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B1")]
			[Address(RVA = "0x9065", Offset = "0x9065", VA = "0x9065")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B3 RID: 16819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEF")]
		public BackTime CurrentSeasonBacktime
		{
			[Token(Token = "0x60041B2")]
			[Address(RVA = "0x9066", Offset = "0x9066", VA = "0x9066")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B3")]
			[Address(RVA = "0x9067", Offset = "0x9067", VA = "0x9067")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B5 RID: 16821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF0")]
		public BackTime NextSeasonBacktime
		{
			[Token(Token = "0x60041B4")]
			[Address(RVA = "0x9068", Offset = "0x9068", VA = "0x9068")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B5")]
			[Address(RVA = "0x9069", Offset = "0x9069", VA = "0x9069")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060041B7 RID: 16823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF1")]
		public BackTime AccelerationCooldown
		{
			[Token(Token = "0x60041B6")]
			[Address(RVA = "0x906A", Offset = "0x906A", VA = "0x906A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041B7")]
			[Address(RVA = "0x906B", Offset = "0x906B", VA = "0x906B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		// (set) Token: 0x060041B9 RID: 16825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF2")]
		public uint CurrentSeasonId
		{
			[Token(Token = "0x60041B8")]
			[Address(RVA = "0x906C", Offset = "0x906C", VA = "0x906C")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60041B9")]
			[Address(RVA = "0x906D", Offset = "0x906D", VA = "0x906D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CF3")]
		public SeasonLeagueDic CurrenSeasonLeagueDic
		{
			[Token(Token = "0x60041BA")]
			[Address(RVA = "0x906E", Offset = "0x906E", VA = "0x906E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x17000CF4")]
		public ulong EnemyClanId
		{
			[Token(Token = "0x60041BB")]
			[Address(RVA = "0x906F", Offset = "0x906F", VA = "0x906F")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060041BC RID: 16828 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x17000CF5")]
		public bool CanAccelerate
		{
			[Token(Token = "0x60041BC")]
			[Address(RVA = "0x9070", Offset = "0x9070", VA = "0x9070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BD")]
		[Address(RVA = "0x9071", Offset = "0x9071", VA = "0x9071")]
		public ClanWarsModel(UserData user)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Clans_ClanWars_Model_ClanWarsModel___ctor
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param2 = *(undefined4 *)(param1 + 0x10);
		  return (uint)(*(int *)(param1 + 0x10) != 0);
		}
		*/

		}

		// Token: 0x060041BE RID: 16830 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x60041BE")]
		[Address(RVA = "0x9072", Offset = "0x9072", VA = "0x9072")]
		public bool TryGetActiveWar(out ProtoGetActiveWarInfoAns.Types.ActiveWarInfo activeWar)
		{
		/* --- GHIDRA: TryGetActiveWar ---
		void Gameplay_Clans_ClanWars_Model_ClanWarsModel__TryGetActiveWar
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  float param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a577c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577c6 = '\x01';
		  }
		  *(int *)(param1 + 0x10) = param2;
		  if ((param2 != 0) && (*(int *)(param2 + 0xc) != 0)) {
		    uVar1 = *(uint *)(*(int *)(param2 + 0xc) + 0x18);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331((ulonglong)uVar1,0);
		    uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,param2_00,0);
		    *(undefined4 *)(param1 + 0x18) = uVar2;
		    *(undefined4 *)(param1 + 0x14) = *(undefined4 *)(param2 + 0xc);
		    return;
		  }
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BF")]
		[Address(RVA = "0x9073", Offset = "0x9073", VA = "0x9073")]
		public void UpdateActiveWar(ProtoGetActiveWarInfoAns.Types.ActiveWarInfo activeWarInfo)
		{
		/* --- GHIDRA: UpdateActiveWar ---
		void Gameplay_Clans_ClanWars_Model_ClanWarsModel__UpdateActiveWar
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  float fVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a577c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577c7 = '\x01';
		  }
		  if (*(int *)(param2 + 0xc) == 0) {
		    *(undefined4 *)(param1 + 0x1c) = 0;
		    uVar3 = 0;
		  }
		  else {
		    uVar1 = *(uint *)(*(int *)(param2 + 0xc) + 0x10);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar2 = func_ii_7331((ulonglong)uVar1,0);
		    uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,fVar2,0);
		    *(undefined4 *)(param1 + 0x1c) = uVar3;
		    uVar3 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc);
		  }
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  if (*(int *)(param2 + 0x10) != 0) {
		    uVar1 = *(uint *)(*(int *)(param2 + 0x10) + 0x10);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar2 = func_ii_7331((ulonglong)uVar1,0);
		    uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,fVar2,0);
		    *(undefined4 *)(param1 + 0x20) = uVar3;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C0")]
		[Address(RVA = "0x9074", Offset = "0x9074", VA = "0x9074")]
		public void PopulateSeasonInfo(ProtoGetCurrentSeasonInfoAns info)
		{
		/* --- GHIDRA: PopulateSeasonInfo ---
		void Gameplay_Clans_ClanWars_Model_ClanWarsModel__PopulateSeasonInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  float param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a577c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577c8 = '\x01';
		  }
		  uVar1 = *(uint *)(param2 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)uVar1,0);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,param2_00,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C1")]
		[Address(RVA = "0x9075", Offset = "0x9075", VA = "0x9075")]
		public void HandleSeasonStarted(ClanWarSeasonInfo seasonInfo)
		{
		}

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[FieldOffset(Offset = "0x10")]
		private ProtoGetActiveWarInfoAns.Types.ActiveWarInfo _activeWarInfo;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentSeasonId ---
		undefined4
		Gameplay_Clans_ClanWars_Model_ClanWarsModel__set_CurrentSeasonId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a577c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a577c3 = '\x01';
		  }
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  param2_00 = *(undefined4 *)(param1 + 0x28);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80dde2f2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dde2f2:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = Core_Gameplay_Managers_ClansManager__set_Controller(uVar4,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetClanSeasonDic(uVar2,param2_00,uVar4,0);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_CurrenSeasonLeagueDic ---
		longlong Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_CurrenSeasonLeagueDic
		                   (int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (*(int *)(param1 + 0x10) == 0) {
		    return 0;
		  }
		  lVar2 = *(longlong *)(*(int *)(*(int *)(*(int *)(param1 + 0x10) + 0xc) + 0x10) + 0x10);
		  lVar1 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		  if (lVar2 == lVar1) {
		    lVar2 = *(longlong *)(*(int *)(*(int *)(*(int *)(param1 + 0x10) + 0xc) + 0x14) + 0x10);
		  }
		  return lVar2;
		}
		*/


		/* --- GHIDRA: get_EnemyClanId ---
		uint Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_EnemyClanId(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  if (DAT_ram_00a577c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577c4 = '\x01';
		  }
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x18),0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  return (uint)(*(float *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 4) < fVar1);
		}
		*/


		/* --- GHIDRA: get_CanAccelerate ---
		void Gameplay_Clans_ClanWars_Model_ClanWarsModel__get_CanAccelerate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a577c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a577c5 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80dde473;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dde473:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  return;
		}
		*/

}
