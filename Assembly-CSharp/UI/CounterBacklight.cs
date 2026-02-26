using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public class CounterBacklight : MonoBehaviour
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x17000101")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x5BE4", Offset = "0x5BE4", VA = "0x5BE4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x5BE5", Offset = "0x5BE5", VA = "0x5BE5")]
		public void SetIsEnabled(bool value)
		{
		/* --- GHIDRA: SetIsEnabled ---
		void UI_CounterBacklight__SetIsEnabled(int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  undefined4 param1_00;
		  
		  bVar1 = *(byte *)(param1 + 0x18);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)bVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1D26", Offset = "0x1D26", VA = "0x1D26")]
		public void SetText(string value)
		{
		/* --- GHIDRA: SetText ---
		undefined4 UI_CounterBacklight__SetText(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59485 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_EffectView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59485 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x30);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_6805(param1_00,uVar1,Method_UnityEngine_Object_Instantiate_EffectView___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x5BE6", Offset = "0x5BE6", VA = "0x5BE6")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_CounterBacklight__Awake(int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  iVar2 = func_ii_12174(param1,0);
		  if (iVar2 != 0) {
		    bVar1 = *(byte *)(param1 + 0x18);
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x10),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)bVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x5BE7", Offset = "0x5BE7", VA = "0x5BE7")]
		private void OnValidate()
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x5BE8", Offset = "0x5BE8", VA = "0x5BE8")]
		public CounterBacklight()
		{
		/* --- GHIDRA: .ctor ---
		void UI_CounterBacklight___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b86e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a5b86e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _appearEnabled;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TMP_Text _text;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _isEnabled;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsEnabled ---
		void UI_CounterBacklight__get_IsEnabled(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  *(char *)(param1 + 0x18) = (char)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

}
