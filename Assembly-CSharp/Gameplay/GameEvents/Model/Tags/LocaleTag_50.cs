using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	public class LocaleTag_50 : AbstractTag
	{
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x17000903")]
		private int StartIndexInStringParams
		{
			[Token(Token = "0x6002E85")]
			[Address(RVA = "0x7F00", Offset = "0x7F00", VA = "0x7F00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x17000904")]
		private int LenInStringParams
		{
			[Token(Token = "0x6002E86")]
			[Address(RVA = "0x7F01", Offset = "0x7F01", VA = "0x7F01")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x6002E87")]
		[Address(RVA = "0x7F02", Offset = "0x7F02", VA = "0x7F02", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x7F03", Offset = "0x7F03", VA = "0x7F03")]
		public LocaleTag_50()
		{
		}

		// Token: 0x0400197D RID: 6525
		[Token(Token = "0x400197D")]
		public const string TEXT_CONTENT = "string";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LenInStringParams ---
		int Gameplay_GameEvents_Model_Tags_LocaleTag_50__get_LenInStringParams
		              (int *param1,undefined4 param2,int param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
		  int local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a574dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27485);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10632);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7422);
		    DAT_ram_00a574dd = '\x01';
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
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar1;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_27485,0);
		    if (iVar3 != 0) {
		      piVar6 = (int *)param1[2];
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d96079;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d96079:
		      iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      iVar7 = *(int *)(iVar3 + 0xc);
		      iVar3 = 0;
		      if (ABS(*(double *)(param1[5] + 0x10)) < 2147483648.0) {
		        iVar8 = (int)*(double *)(param1[5] + 0x10);
		      }
		      else {
		        iVar8 = -0x80000000;
		      }
		      iVar8 = iVar8 + iVar7 + -2;
		      if ((iVar8 < 0) ||
		         (iVar5 = *(int *)(*(int *)(param3 + 0x24) + 0x38), *(int *)(iVar5 + 0xc) <= iVar8)) {
		        piVar6 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		        if ((StringLiteral_10632 != 0) &&
		           (iVar5 = func_ii_1082(StringLiteral_10632,*(undefined4 *)(*piVar6 + 0x20)),
		           iVar3 = StringLiteral_10632, iVar5 == 0)) {
		          uVar1 = func_ii_1083();
		          func_ii_1050(uVar1,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar6[4] = iVar3;
		        local_4 = iVar8;
		        iVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		        if ((iVar3 != 0) &&
		           (iVar8 = func_ii_1082(iVar3,*(undefined4 *)(*piVar6 + 0x20)), iVar8 == 0)) {
		          uVar1 = func_ii_1083();
		          func_ii_1050(uVar1,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar6[5] = iVar3;
		        local_8 = *(undefined4 *)(*(int *)(*(int *)(param3 + 0x24) + 0x38) + 0xc);
		        iVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		        if ((iVar3 != 0) &&
		           (iVar8 = func_ii_1082(iVar3,*(undefined4 *)(*piVar6 + 0x20)), iVar8 == 0)) {
		          uVar1 = func_ii_1083();
		          func_ii_1050(uVar1,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar6[6] = iVar3;
		        local_c = iVar7 + -1;
		        iVar3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		        if ((iVar3 != 0) &&
		           (iVar7 = func_ii_1082(iVar3,*(undefined4 *)(*piVar6 + 0x20)), iVar7 == 0)) {
		          uVar1 = func_ii_1083();
		          func_ii_1050(uVar1,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar6[7] = iVar3;
		        uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                          (StringLiteral_7422,piVar6,0);
		        *param4 = uVar1;
		      }
		      else {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar5,iVar8,
		                           Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		        *param4 = uVar1;
		      }
		    }
		  }
		  return iVar2;
		}
		*/

}
