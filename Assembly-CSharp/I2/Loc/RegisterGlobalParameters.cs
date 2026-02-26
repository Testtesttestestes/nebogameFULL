using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020013B2 RID: 5042
	[Token(Token = "0x20013B2")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		// Token: 0x060077E1 RID: 30689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E1")]
		[Address(RVA = "0xC13C", Offset = "0xC13C", VA = "0xC13C", Slot = "5")]
		public virtual void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void I2_Loc_RegisterGlobalParameters__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ILocalizationParamsManager__Remove__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e24 = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  func_ii_4876(*(undefined4 *)(*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x5c) + 0x10),param1,
		               Method_System_Collections_Generic_List_ILocalizationParamsManager__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E2")]
		[Address(RVA = "0xC13D", Offset = "0xC13D", VA = "0xC13D", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077E3")]
		[Address(RVA = "0xC13E", Offset = "0xC13E", VA = "0xC13E", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E4")]
		[Address(RVA = "0xC13F", Offset = "0xC13F", VA = "0xC13F")]
		public RegisterGlobalParameters()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_RegisterGlobalParameters___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a54e25 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_ResourceManager___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_ResourceManager_MyOnLevelWasLoaded__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ResourceManager_var);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ResourceManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Type___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8920);
		    DAT_ram_00a54e25 = '\x01';
		  }
		  uVar6 = **(undefined4 **)(I2_Loc_ResourceManager_TypeInfo + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar6,0,0);
		  iVar2 = func_ii_3812(**(undefined4 **)(I2_Loc_ResourceManager_TypeInfo + 0x5c),0,0);
		  uVar6 = I2_Loc_ResourceManager_var;
		  if (iVar2 != 0) {
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    uVar6 = func_ii_2734(uVar6,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    piVar3 = (int *)UnityEngine_Object__CheckNullArgument(uVar6,0);
		    if (piVar3 == (int *)0x0) {
		      **(undefined4 **)(I2_Loc_ResourceManager_TypeInfo + 0x5c) = 0;
		    }
		    else {
		      if (((uint)*(byte *)(*piVar3 + 0xb8) < (uint)*(byte *)(I2_Loc_ResourceManager_TypeInfo + 0xb8)
		          ) || (*(int *)(*(int *)(*piVar3 + 100) +
		                         (uint)*(byte *)(I2_Loc_ResourceManager_TypeInfo + 0xb8) * 4 + -4) !=
		                I2_Loc_ResourceManager_TypeInfo)) {
		        System_Activator__CreateInstance(piVar3,I2_Loc_ResourceManager_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      **(int **)(I2_Loc_ResourceManager_TypeInfo + 0x5c) = (int)piVar3;
		      if (((uint)*(byte *)(*piVar3 + 0xb8) < (uint)*(byte *)(I2_Loc_ResourceManager_TypeInfo + 0xb8)
		          ) || (*(int *)(*(int *)(*piVar3 + 100) +
		                         (uint)*(byte *)(I2_Loc_ResourceManager_TypeInfo + 0xb8) * 4 + -4) !=
		                I2_Loc_ResourceManager_TypeInfo)) {
		        System_Activator__CreateInstance(piVar3,I2_Loc_ResourceManager_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  uVar6 = **(undefined4 **)(I2_Loc_ResourceManager_TypeInfo + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar6,0,0);
		  if (iVar2 != 0) {
		    piVar3 = (int *)Mono_Security_ASN1Convert__ToOid(System_Type___TypeInfo,1);
		    uVar6 = I2_Loc_ResourceManager_var;
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    iVar2 = func_ii_2734(uVar6,0);
		    if ((iVar2 != 0) && (iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar3 + 0x20)), iVar4 == 0)) {
		      uVar6 = func_ii_1083();
		      func_ii_1050(uVar6,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar3[4] = iVar2;
		    uVar6 = unnamed_function_1417(UnityEngine_GameObject_TypeInfo);
		    func_ii_8020(uVar6,StringLiteral_8920,piVar3,0);
		    uVar5 = UnityEngine_Object__DontDestroyOnLoad(uVar6,0);
		    UnityEngine_Collider2D__set_isTrigger(uVar6,uVar5 | 0x3d,0);
		    uVar6 = func_ii_6601(uVar6,Method_UnityEngine_GameObject_GetComponent_ResourceManager___);
		    **(undefined4 **)(I2_Loc_ResourceManager_TypeInfo + 0x5c) = uVar6;
		    uVar6 = unnamed_function_1417(UnityEngine_Events_UnityAction_Scene__LoadSceneMode__TypeInfo);
		    UnityEngine_Events_UnityAction_InputAction_CallbackContext___Invoke
		              (uVar6,0,Method_I2_Loc_ResourceManager_MyOnLevelWasLoaded__,0);
		    if (*(int *)(UnityEngine_SceneManagement_SceneManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    }
		    UnityEngine_SceneManagement_SceneManager__LoadFirstScene_Internal(uVar6,0);
		  }
		  if (iVar1 != 0) {
		    if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Application_TypeInfo);
		    }
		    iVar1 = func_ii_3441(0);
		    if (iVar1 != 0) {
		      uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (**(undefined4 **)(I2_Loc_ResourceManager_TypeInfo + 0x5c),0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Object__FindObjectsByType(uVar6,0);
		    }
		  }
		  return **(undefined4 **)(I2_Loc_ResourceManager_TypeInfo + 0x5c);
		}
		*/

		}
	}
}
