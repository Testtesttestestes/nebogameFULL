using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	public class SimpleIconValue : MonoBehaviour
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011A")]
		public string IconAssetId
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x5C3F", Offset = "0x5C3F", VA = "0x5C3F")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1AFE", Offset = "0x1AFE", VA = "0x1AFE")]
			set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		public string Value
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x5C40", Offset = "0x5C40", VA = "0x5C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1B00", Offset = "0x1B00", VA = "0x1B00")]
			set
			{
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x5C41", Offset = "0x5C41", VA = "0x5C41", Slot = "4")]
		protected virtual void HandleValueChanged()
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1B02", Offset = "0x1B02", VA = "0x1B02")]
		public void SetColor(in Color value)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x5C42", Offset = "0x5C42", VA = "0x5C42")]
		public SimpleIconValue()
		{
		}

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _valueLabel;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x18")]
		private string _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IconAssetId ---
		undefined4 UI_SimpleIconValue__set_IconAssetId(double param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int *piVar1;
		  undefined4 uVar2;
		  float8 local_8;
		  
		  local_8 = (float8)param1;
		  if (DAT_ram_00a6281c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Globalization_NumberFormatInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_625);
		    DAT_ram_00a6281c = '\x01';
		  }
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  if (*(int *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 0xc) == 0) {
		    if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		    }
		    piVar1 = (int *)System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x138) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x13c));
		    piVar1 = (int *)System_Globalization_NumberFormatInfo__GetInstance(uVar2,0);
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    param2_00 = System_Globalization_NumberFormatInfo_TypeInfo;
		    if (piVar1 == (int *)0x0) {
		      *(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 0xc) = 0;
		    }
		    else if ((System_Globalization_NumberFormatInfo_TypeInfo != *piVar1) ||
		            (*(int **)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 0xc) = piVar1,
		            *piVar1 != param2_00)) {
		      System_Activator__CreateInstance(piVar1,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    System_Globalization_NumberFormatInfo__get_NumberGroupSeparator(piVar1,param2,0);
		  }
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar2 = System_Double__ToString
		                    (&local_8,StringLiteral_625,
		                     *(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 0xc),0);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_Value ---
		void UI_SimpleIconValue__get_Value(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		uint * UI_SimpleIconValue__set_Value(int *param1,int param2,int param3)
		
		{
		  uint *puVar1;
		  undefined4 *puVar2;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  ulonglong uVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  uint uVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  uVar11 = 0;
		  uVar7 = 0;
		  if (*(int *)(param3 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    if (*(int *)(param3 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		    }
		  }
		  if (param1 == (int *)0x0) {
		    uVar5 = unnamed_function_2232(&StringLiteral_27321);
		    uVar5 = System_Security_Cryptography_AesTransform___cctor(uVar5,0);
		    func_ii_1050(uVar5,param3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param2 == 0) {
		    uVar5 = unnamed_function_2232(&StringLiteral_26138);
		    uVar5 = System_Security_Cryptography_AesTransform___cctor(uVar5,0);
		    func_ii_1050(uVar5,param3);
		code_r0x8260e244:
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar6 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar6 = func_ii_1079(iVar6);
		  }
		  iVar10 = *param1;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (iVar6 == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8260dd7e;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(param1,iVar6,0);
		code_r0x8260dd7e:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param1,puVar1[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  puVar1 = (uint *)0x0;
		code_r0x8260ddb5:
		  piVar3 = local_4;
		  iVar6 = *local_4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		        puVar2 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		        goto code_r0x8260de4e;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar11);
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x8260e0a9:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x8260e0b6;
		  }
		code_r0x8260de4e:
		  DAT_ram_009d3e38 = (uint *)0x0;
		  iVar6 = import::env::invoke_iii(*puVar2,piVar3,puVar2[1]);
		  piVar3 = local_4;
		  if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x8260e0a9;
		  if (iVar6 == 0) {
		    iVar10 = 0xc;
		    iVar6 = 0;
		    puVar4 = DAT_ram_009d3e38;
		    goto code_r0x8260e103;
		  }
		  iVar6 = *(int *)(*(int *)(param3 + 0x1c) + 0x10);
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		    if (DAT_ram_009d3e38 != (uint *)0x1) goto code_r0x8260dee3;
		code_r0x8260e07b:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x8260e0b6;
		  }
		code_r0x8260dee3:
		  iVar10 = *piVar3;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      piVar8 = (int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8);
		      if (iVar6 == *piVar8) {
		        puVar2 = (undefined4 *)(iVar10 + piVar8[1] * 8 + 0xc0);
		        goto code_r0x8260df69;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,iVar6,0);
		  if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x8260e07b;
		code_r0x8260df69:
		  DAT_ram_009d3e38 = (uint *)0x0;
		  puVar4 = (uint *)import::env::invoke_iii(*puVar2,piVar3,puVar2[1]);
		  if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x8260e07b;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  iVar10 = import::env::invoke_iiii
		                     (*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x20),puVar4,
		                      *(undefined4 *)(param2 + 0x14));
		  iVar6 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar6 != 1) {
		    if (iVar10 != 0) {
		      puVar1 = puVar4;
		      if (uVar7 == 0x7fffffffffffffff) {
		        DAT_ram_009d3e38 = (uint *)0x0;
		        uVar5 = import::env::invoke_i(s_var<private>_posTex__array<vec4<_ram_00000655 + 499);
		        if (DAT_ram_009d3e38 != (uint *)0x1) {
		          DAT_ram_009d3e38 = (uint *)0x0;
		          import::env::invoke_vii(0x41b,uVar5,param3);
		          if (DAT_ram_009d3e38 != (uint *)0x1) goto code_r0x8260e244;
		        }
		        DAT_ram_009d3e38 = (uint *)0x0;
		        uVar7 = 0x7fffffffffffffff;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8260e0b6;
		      }
		      uVar7 = uVar7 + 1;
		    }
		    goto code_r0x8260ddb5;
		  }
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8260e0b6:
		  iVar6 = global_1;
		  iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar6) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar6 = *piVar3;
		    iVar10 = 0;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    puVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (puVar4 != (uint *)0x1) {
		code_r0x8260e103:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar11 = 0;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8)) {
		              puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x8260e17b;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8260e17b:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar10 == 0) ||
		         (((((iVar10 != 1 && (iVar10 != 2)) && (iVar10 != 3)) &&
		           ((((iVar10 != 4 && (iVar10 != 5)) && ((iVar10 != 6 && ((iVar10 != 7 && (iVar10 != 8))))))
		            && (iVar10 != 9)))) && (((iVar10 != 10 && (iVar10 != 0xb)) && (iVar10 == 0xc)))))) {
		        if (1 < uVar7) {
		          uVar5 = System_Linq_Error__MoreThanOneElement(0);
		          func_ii_1050(uVar5,param3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        puVar4 = puVar1;
		        if ((int)uVar7 != 1) {
		          puVar4 = (uint *)0x0;
		        }
		      }
		      return puVar4;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_00004c04 + 0x46,&local_c);
		  iVar6 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
