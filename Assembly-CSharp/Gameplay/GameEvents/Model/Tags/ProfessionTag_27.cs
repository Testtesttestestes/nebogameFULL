using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x20007AF")]
	public class ProfessionTag_27 : AbstractTag
	{
		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x17000909")]
		public uint ProfessionId
		{
			[Token(Token = "0x6002E94")]
			[Address(RVA = "0x7F0F", Offset = "0x7F0F", VA = "0x7F0F")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x1700090A")]
		public uint ProfessionLevel
		{
			[Token(Token = "0x6002E95")]
			[Address(RVA = "0x7F10", Offset = "0x7F10", VA = "0x7F10")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x7F11", Offset = "0x7F11", VA = "0x7F11", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E97")]
		[Address(RVA = "0x7F12", Offset = "0x7F12", VA = "0x7F12")]
		public ProfessionTag_27()
		{
		}

		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		public const string PROFESSION_TITLE = "profession_title";

		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		public const string PROFESSION_LEVEL = "profession_level";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ProfessionLevel ---
		int Gameplay_GameEvents_Model_Tags_ProfessionTag_27__get_ProfessionLevel
		              (int *param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  double dVar5;
		  uint uVar6;
		  int param2_00;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a574e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26189);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26188);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574e1 = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
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
		  if (iVar2 == 0) {
		    *param4 = 0;
		  }
		  else {
		    iVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = iVar3;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_26189,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_26188,0);
		      if (iVar3 != 0) {
		        dVar5 = *(double *)(param1[5] + 0x18);
		        if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		          iVar3 = (int)dVar5;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar5) < 2147483648.0) {
		          local_4 = (int)dVar5;
		        }
		        else {
		          local_4 = -0x80000000;
		        }
		        if (0.0 <= dVar5) {
		          local_4 = iVar3;
		        }
		        iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		        if (iVar3 == 0) {
		          iVar3 = StringLiteral_5;
		        }
		        *param4 = iVar3;
		      }
		    }
		    else {
		      param1_00 = (int *)param1[2];
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar6 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d97080;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d97080:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		      dVar5 = *(double *)(param1[5] + 0x10);
		      if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		        iVar3 = (int)dVar5;
		      }
		      else {
		        iVar3 = 0;
		      }
		      if (ABS(dVar5) < 2147483648.0) {
		        param2_00 = (int)dVar5;
		      }
		      else {
		        param2_00 = -0x80000000;
		      }
		      if (0.0 <= dVar5) {
		        param2_00 = iVar3;
		      }
		      iVar3 = Core_Extensions_Dict_DictExt__GetIsleAnimationDic(uVar1,param2_00,0);
		      if (iVar3 == 0) {
		        dVar5 = *(double *)(param1[5] + 0x10);
		        if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		          iVar3 = (int)dVar5;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar5) < 2147483648.0) {
		          local_8 = (int)dVar5;
		        }
		        else {
		          local_8 = -0x80000000;
		        }
		        if (0.0 <= dVar5) {
		          local_8 = iVar3;
		        }
		        uVar1 = func_ii_1081(DAT_ram_00a66958,&local_8);
		        iVar3 = func_ii_4419(StringLiteral_12779,uVar1,0);
		        *param4 = iVar3;
		      }
		      else {
		        iVar3 = Core_Extensions_Dict_PortalDicExt___c__DisplayClass8_0___GetPortalStageDic_b__0
		                          (iVar3,0);
		        *param4 = iVar3;
		      }
		    }
		  }
		  return iVar2;
		}
		*/

}
