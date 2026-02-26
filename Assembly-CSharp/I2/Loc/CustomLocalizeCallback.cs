using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	// Token: 0x020013A0 RID: 5024
	[Token(Token = "0x20013A0")]
	[AddComponentMenu("I2/Localization/I2 Localize Callback")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		// Token: 0x060077A3 RID: 30627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A3")]
		[Address(RVA = "0xC101", Offset = "0xC101", VA = "0xC101")]
		public void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void I2_Loc_CustomLocalizeCallback__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54e01 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_CustomLocalizeCallback_OnLocalize__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		    DAT_ram_00a54e01 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(I2_Loc_LocalizationManager_OnLocalizeCallback_TypeInfo);
		  I2_Loc_LocalizationManager__GetParam__EndInvoke
		            (param1_00,param1,Method_I2_Loc_CustomLocalizeCallback_OnLocalize__,0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__add_OnLocalizeEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A4")]
		[Address(RVA = "0xC102", Offset = "0xC102", VA = "0xC102")]
		public void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void I2_Loc_CustomLocalizeCallback__OnDisable(int param1,undefined4 param2)
		
		{
		  UnityEngine_Events_UnityEvent__GetDelegate(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A5")]
		[Address(RVA = "0xC103", Offset = "0xC103", VA = "0xC103")]
		public void OnLocalize()
		{
		/* --- GHIDRA: OnLocalize ---
		void I2_Loc_CustomLocalizeCallback__OnLocalize(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54e02 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityEvent_TypeInfo);
		    DAT_ram_00a54e02 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityEvent_TypeInfo);
		  UnityEngine_Events_UnityAction__Invoke(param1_00,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A6")]
		[Address(RVA = "0xC104", Offset = "0xC104", VA = "0xC104")]
		public CustomLocalizeCallback()
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Type propagation algorithm not settling */
		
		undefined4 I2_Loc_CustomLocalizeCallback___ctor(undefined4 param1,undefined4 param2)
		
		{
		  short sVar1;
		  bool bVar2;
		  ushort uVar3;
		  int param1_00;
		  undefined4 uVar4;
		  int iVar5;
		  ushort *puVar6;
		  ushort *puVar7;
		  int iVar8;
		  undefined4 *puVar9;
		  int iVar10;
		  
		  iVar8 = 0;
		  bVar2 = false;
		  if (DAT_ram_00a54e03 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_char___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_char___);
		    Mono_Security_ASN1__get_Item(&System_Func_char__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_HindiFixer___c__Fix_b__0_0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_HindiFixer___c_TypeInfo);
		    DAT_ram_00a54e03 = '\x01';
		  }
		  param1_00 = I2_Loc_StringObfucator__XoREncode(param1,0);
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    return param1;
		  }
		  do {
		    iVar5 = param1_00 + iVar8 * 2;
		    puVar6 = (ushort *)(iVar5 + 0x10);
		    if (*puVar6 == 0x93f) {
		      puVar7 = (ushort *)(iVar5 + 0xe);
		      uVar3 = *puVar7;
		      if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		        func_ii_306000(DAT_ram_00a66974);
		      }
		      iVar10 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize((uint)uVar3,0);
		      if ((iVar10 == 0) && (*puVar7 != 0)) {
		        *puVar6 = *puVar7;
		        *puVar7 = 0x93f;
		        bVar2 = true;
		      }
		    }
		    iVar10 = *(int *)(param1_00 + 0xc);
		    if (iVar8 != iVar10 + -1) {
		      uVar3 = *puVar6;
		      if (uVar3 == 0x901) {
		        uVar3 = 0x950;
		        sVar1 = *(short *)(iVar5 + 0x12);
		      }
		      else {
		        if ((((uVar3 == 0x902) || (uVar3 == 0x903)) || (uVar3 == 0x904)) ||
		           ((uVar3 == 0x905 || (uVar3 == 0x906)))) goto code_r0x80b1e352;
		        if (uVar3 == 0x907) {
		          uVar3 = 0x90c;
		          sVar1 = *(short *)(iVar5 + 0x12);
		        }
		        else if (uVar3 == 0x908) {
		          uVar3 = 0x961;
		          sVar1 = *(short *)(iVar5 + 0x12);
		        }
		        else {
		          if ((uVar3 == 0x909) || (uVar3 == 0x90a)) goto code_r0x80b1e352;
		          if (uVar3 == 0x90b) {
		            uVar3 = 0x960;
		            sVar1 = *(short *)(iVar5 + 0x12);
		          }
		          else {
		            if (((((((uVar3 == 0x90c) || (uVar3 == 0x90d)) || (uVar3 == 0x90e)) ||
		                  (((uVar3 == 0x90f || (uVar3 == 0x910)) ||
		                   ((uVar3 == 0x911 || ((uVar3 == 0x912 || (uVar3 == 0x913)))))))) ||
		                 ((uVar3 == 0x914 || (((uVar3 == 0x915 || (uVar3 == 0x916)) || (uVar3 == 0x917))))))
		                || (((((uVar3 == 0x918 || (uVar3 == 0x919)) ||
		                      (((uVar3 == 0x91a || ((uVar3 == 0x91b || (uVar3 == 0x91c)))) ||
		                       (uVar3 == 0x91d)))) ||
		                     ((((((uVar3 == 0x91e || (uVar3 == 0x91f)) || (uVar3 == 0x920)) ||
		                        ((uVar3 == 0x921 || (uVar3 == 0x922)))) ||
		                       ((uVar3 == 0x923 || ((uVar3 == 0x924 || (uVar3 == 0x925)))))) ||
		                      (uVar3 == 0x926)))) ||
		                    ((((((uVar3 == 0x927 || (uVar3 == 0x928)) || (uVar3 == 0x929)) ||
		                       (((uVar3 == 0x92a || (uVar3 == 0x92b)) ||
		                        ((uVar3 == 0x92c || ((uVar3 == 0x92d || (uVar3 == 0x92e)))))))) ||
		                      (uVar3 == 0x92f)) ||
		                     (((uVar3 == 0x930 || (uVar3 == 0x931)) || (uVar3 == 0x932)))))))) ||
		               (((uVar3 == 0x933 || (uVar3 == 0x934)) ||
		                (((uVar3 == 0x935 || ((uVar3 == 0x936 || (uVar3 == 0x937)))) ||
		                 ((uVar3 == 0x938 ||
		                  (((((uVar3 == 0x939 || (uVar3 == 0x93a)) || (uVar3 == 0x93b)) ||
		                    ((uVar3 == 0x93c || (uVar3 == 0x93d)))) || (uVar3 == 0x93e))))))))))
		            goto code_r0x80b1e352;
		            if (uVar3 == 0x93f) {
		              uVar3 = 0x962;
		              sVar1 = *(short *)(iVar5 + 0x12);
		            }
		            else if (uVar3 == 0x940) {
		              uVar3 = 0x963;
		              sVar1 = *(short *)(iVar5 + 0x12);
		            }
		            else {
		              if ((uVar3 == 0x941) || (uVar3 == 0x942)) goto code_r0x80b1e352;
		              if (uVar3 == 0x943) {
		                uVar3 = 0x944;
		                sVar1 = *(short *)(iVar5 + 0x12);
		              }
		              else {
		                if (uVar3 != 0x964) goto code_r0x80b1e352;
		                uVar3 = 0x93d;
		                sVar1 = *(short *)(iVar5 + 0x12);
		              }
		            }
		          }
		        }
		      }
		      if (sVar1 == 0x93c) {
		        *puVar6 = uVar3;
		        *(undefined2 *)(iVar5 + 0x12) = 0;
		        bVar2 = true;
		      }
		    }
		code_r0x80b1e352:
		    iVar8 = iVar8 + 1;
		    if (iVar10 <= iVar8) {
		      if (bVar2) {
		        if (*(int *)(I2_Loc_HindiFixer___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(I2_Loc_HindiFixer___c_TypeInfo);
		        }
		        puVar9 = *(undefined4 **)(I2_Loc_HindiFixer___c_TypeInfo + 0x5c);
		        iVar8 = puVar9[1];
		        if (iVar8 == 0) {
		          if (*(int *)(I2_Loc_HindiFixer___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_HindiFixer___c_TypeInfo);
		            puVar9 = *(undefined4 **)(I2_Loc_HindiFixer___c_TypeInfo + 0x5c);
		          }
		          uVar4 = *puVar9;
		          iVar8 = unnamed_function_1417(System_Func_char__bool__TypeInfo);
		          System_Func_CancellationToken__UniTaskVoid___Invoke
		                    (iVar8,uVar4,Method_I2_Loc_HindiFixer___c__Fix_b__0_0__,0);
		          *(int *)(*(int *)(I2_Loc_HindiFixer___c_TypeInfo + 0x5c) + 4) = iVar8;
		        }
		        uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                          (param1_00,iVar8,Method_System_Linq_Enumerable_Where_char___);
		        uVar4 = System_Linq_Enumerable__ToArray_ValueTuple_int__double__
		                          (uVar4,Method_System_Linq_Enumerable_ToArray_char___);
		        uVar4 = System_String__ToCharArray(0,uVar4,0);
		        System_Collections_CollectionBase___ctor(uVar4,param1,0);
		        return uVar4;
		      }
		      return param1;
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x04003E72 RID: 15986
		[Token(Token = "0x4003E72")]
		[FieldOffset(Offset = "0x10")]
		public UnityEvent _OnLocalize;
	}
}
