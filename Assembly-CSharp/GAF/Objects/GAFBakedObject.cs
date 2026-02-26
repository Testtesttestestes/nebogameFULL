using System;
using GAFInternal.Data;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Objects
{
	// Token: 0x020013DC RID: 5084
	[Token(Token = "0x20013DC")]
	[Serializable]
	public class GAFBakedObject : GAFBakedObjectInternal
	{
		// Token: 0x06007969 RID: 31081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007969")]
		[Address(RVA = "0xC249", Offset = "0xC249", VA = "0xC249")]
		public void addController()
		{
		/* --- GHIDRA: addController ---
		undefined4 GAF_Objects_GAFBakedObject__addController(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54ea1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54ea1 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600796A RID: 31082 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x600796A")]
		[Address(RVA = "0xC24A", Offset = "0xC24A", VA = "0xC24A")]
		public bool hasController()
		{
		/* --- GHIDRA: hasController ---
		void GAF_Objects_GAFBakedObject__hasController(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  GAFInternal_Objects_GAFBakedObjectInternal__initialize(param1,0);
		  if (DAT_ram_00a54ea1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54ea1 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    *(int *)(*(int *)(param1 + 0x10) + 0x10) = param1;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796B")]
		[Address(RVA = "0x190E", Offset = "0x190E", VA = "0x190E")]
		public void removeController()
		{
		/* --- GHIDRA: removeController ---
		int * GAF_Objects_GAFBakedObject__removeController(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600796C RID: 31084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796C")]
		[Address(RVA = "0xC24B", Offset = "0xC24B", VA = "0xC24B", Slot = "13")]
		public override void reload()
		{
		/* --- GHIDRA: reload ---
		void GAF_Objects_GAFBakedObject__reload
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  GAFInternal_Objects_GAFBakedObjectInternal__reload(param1,param2,param3,0);
		  if (DAT_ram_00a54ea1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54ea1 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    GAFInternal_Objects_GAFBakedObjectInternal__get_currentMaterial(param1,0);
		    GAFInternal_Objects_GAFBakedObjectInternal__get_previousState(param1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600796D RID: 31085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796D")]
		[Address(RVA = "0xC24C", Offset = "0xC24C", VA = "0xC24C", Slot = "14")]
		public override void updateToState(GAFObjectStateData _State, bool _Refresh)
		{
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600796E")]
		[Address(RVA = "0xC24D", Offset = "0xC24D", VA = "0xC24D")]
		public GAFBakedObject()
		{
		}

		// Token: 0x04003F5D RID: 16221
		[Token(Token = "0x4003F5D")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		private GAFBakedObjectController m_Controller;
	}
}
