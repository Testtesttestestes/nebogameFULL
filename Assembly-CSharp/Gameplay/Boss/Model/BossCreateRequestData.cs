using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Boss;
using Protocol.Dic;
using Utils;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B89 RID: 2953
	[Token(Token = "0x2000B89")]
	public class BossCreateRequestData
	{
		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x17000E61")]
		public ulong RequesterId
		{
			[Token(Token = "0x60047CB")]
			[Address(RVA = "0x9656", Offset = "0x9656", VA = "0x9656")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E62")]
		public BackTime BackTime
		{
			[Token(Token = "0x60047CC")]
			[Address(RVA = "0x9657", Offset = "0x9657", VA = "0x9657")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047CD")]
			[Address(RVA = "0x9658", Offset = "0x9658", VA = "0x9658")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E63")]
		public BossTypeDic BossTypeDic
		{
			[Token(Token = "0x60047CE")]
			[Address(RVA = "0x9659", Offset = "0x9659", VA = "0x9659")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047CF")]
			[Address(RVA = "0x965A", Offset = "0x965A", VA = "0x965A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E64")]
		public MonsterDic MonsterDic
		{
			[Token(Token = "0x60047D0")]
			[Address(RVA = "0x965B", Offset = "0x965B", VA = "0x965B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047D1")]
			[Address(RVA = "0x965C", Offset = "0x965C", VA = "0x965C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E65")]
		public AprDic AprDic
		{
			[Token(Token = "0x60047D2")]
			[Address(RVA = "0x965D", Offset = "0x965D", VA = "0x965D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047D3")]
			[Address(RVA = "0x965E", Offset = "0x965E", VA = "0x965E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047D4")]
		[Address(RVA = "0x965F", Offset = "0x965F", VA = "0x965F")]
		public BossCreateRequestData(CreateRequestEvt createRequestEvt)
		{
		}

		// Token: 0x04002771 RID: 10097
		[Token(Token = "0x4002771")]
		[FieldOffset(Offset = "0x8")]
		private CreateRequestEvt _rawCreateRequestEvt;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_AprDic ---
		void Gameplay_Boss_Model_BossCreateRequestData__set_AprDic(int param1,int param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined8 uVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a5786d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5786d = '\x01';
		  }
		  *(int *)(param1 + 8) = param2;
		  uVar6 = *(undefined8 *)(param2 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(uVar6,0);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,param2_00,0);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80dea1a5;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dea1a5:
		  uVar6 = CONCAT44(uVar3,piVar4);
		  uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(uVar6,puVar2[1]);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetStoneDic
		                    (uVar1,*(undefined4 *)(*(int *)(param1 + 8) + 0x18),0);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80dea268;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dea268:
		  uVar6 = CONCAT44(uVar3,piVar4);
		  uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(uVar6,puVar2[1]);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                    (uVar1,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80dea32b;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dea32b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar3,piVar4),puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (uVar3,*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  return;
		}
		*/

}
