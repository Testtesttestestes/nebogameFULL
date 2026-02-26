using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	public class SpellTag_5 : AbstractTag
	{
		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x1700090D")]
		public uint SpellId
		{
			[Token(Token = "0x6002E9D")]
			[Address(RVA = "0x7F18", Offset = "0x7F18", VA = "0x7F18")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x1700090E")]
		public uint SpellLevel
		{
			[Token(Token = "0x6002E9E")]
			[Address(RVA = "0x7F19", Offset = "0x7F19", VA = "0x7F19")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x6002E9F")]
		[Address(RVA = "0x7F1A", Offset = "0x7F1A", VA = "0x7F1A", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA0")]
		[Address(RVA = "0x7F1B", Offset = "0x7F1B", VA = "0x7F1B")]
		public SpellTag_5()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GameEvents_Model_Tags_SpellTag_5___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  double dVar3;
		  
		  iVar2 = param1[5];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  dVar3 = *(double *)(iVar2 + iVar1 * 8 + 8);
		  if (ABS(dVar3) < 2147483648.0) {
		    iVar1 = (int)dVar3;
		  }
		  else {
		    iVar1 = -0x80000000;
		  }
		  return iVar1 + -1;
		}
		*/

		}

		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		public const string SPELL_TITLE = "spell_title";

		// Token: 0x0400198A RID: 6538
		[Token(Token = "0x400198A")]
		public const string SPELL_LEVEL = "spell_level";

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		public const string SPELL_VIEW = "spell_view";

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		public const string SPELL_VIEW_PREFAB = "SpellTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SpellLevel ---
		int Gameplay_GameEvents_Model_Tags_SpellTag_5__get_SpellLevel
		              (int *param1,undefined4 param2,int param3,int *param4,int param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  undefined4 uVar7;
		  double dVar8;
		  uint uVar9;
		  int iVar10;
		  int iVar11;
		  int iVar12;
		  int local_4;
		  
		  if (DAT_ram_00a574e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_SpellTagView___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_SpellItemArgs__Init__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolSpellData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14567);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27350);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27349);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27348);
		    DAT_ram_00a574e4 = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  iVar3 = 0;
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 != 0) {
		    iVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = iVar3;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_27349,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_27348,0);
		      if (iVar3 == 0) {
		        iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_27350,0);
		        if (iVar3 == 0) {
		          return iVar2;
		        }
		        iVar3 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                          (param1,StringLiteral_14567,*(undefined4 *)(param5 + 8),
		                           Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_SpellTagView___
		                          );
		        uVar1 = *(undefined4 *)(iVar3 + 0x10);
		        iVar3 = unnamed_function_1417(Protocol_Common_ShortSpellInfo_TypeInfo);
		        iVar10 = param1[5];
		        dVar8 = *(double *)(iVar10 + 0x10);
		        if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		          iVar12 = (int)dVar8;
		        }
		        else {
		          iVar12 = 0;
		        }
		        if (ABS(dVar8) < 2147483648.0) {
		          iVar11 = (int)dVar8;
		        }
		        else {
		          iVar11 = -0x80000000;
		        }
		        if (0.0 <= dVar8) {
		          iVar11 = iVar12;
		        }
		        *(int *)(iVar3 + 0xc) = iVar11;
		        dVar8 = *(double *)(iVar10 + 0x18);
		        if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		          iVar10 = (int)dVar8;
		        }
		        else {
		          iVar10 = 0;
		        }
		        if (ABS(dVar8) < 2147483648.0) {
		          iVar12 = (int)dVar8;
		        }
		        else {
		          iVar12 = -0x80000000;
		        }
		        if (0.0 <= dVar8) {
		          iVar12 = iVar10;
		        }
		        *(int *)(iVar3 + 0x10) = iVar12;
		        uVar7 = *(undefined4 *)(*(int *)(param3 + 0x18) + 8);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar9 = 0;
		        piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar10 = *piVar6;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8 + 4) * 8 + iVar10 +
		                               0x178);
		              goto code_r0x80d97892;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar9);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d97892:
		        uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		        uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		        param1_00 = unnamed_function_1417(Gameplay_School_Model_SchoolSpellData_TypeInfo);
		        Gameplay_School_Model_SchoolSpellData___ctor(param1_00,iVar3,uVar7,uVar5,0);
		        uVar7 = unnamed_function_1417(UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		        Core_Data_Spells_SpellData__get_IsCultSpell(uVar7,param1_00,0);
		        UI_Elements_Buildings_SpellItemArgs___ctor
		                  (uVar1,uVar7,
		                   Method_UI_Elements_GenericList_GenericListElement_SpellItemArgs__Init__);
		        iVar3 = StringLiteral_5;
		      }
		      else {
		        dVar8 = *(double *)(param1[5] + 0x18);
		        if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		          iVar3 = (int)dVar8;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar8) < 2147483648.0) {
		          local_4 = (int)dVar8;
		        }
		        else {
		          local_4 = -0x80000000;
		        }
		        if (0.0 <= dVar8) {
		          local_4 = iVar3;
		        }
		        iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		        if (iVar3 == 0) {
		          iVar3 = StringLiteral_5;
		        }
		      }
		    }
		    else {
		      piVar6 = (int *)param1[2];
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d97647;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d97647:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      dVar8 = *(double *)(param1[5] + 0x10);
		      if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		        iVar3 = (int)dVar8;
		      }
		      else {
		        iVar3 = 0;
		      }
		      if (ABS(dVar8) < 2147483648.0) {
		        iVar10 = (int)dVar8;
		      }
		      else {
		        iVar10 = -0x80000000;
		      }
		      if (0.0 <= dVar8) {
		        iVar10 = iVar3;
		      }
		      uVar1 = Core_Extensions_Dict_DictExt__GetItemQuality(uVar1,iVar10,0);
		      iVar3 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(uVar1,0);
		    }
		  }
		  *param4 = iVar3;
		  return iVar2;
		}
		*/

}
