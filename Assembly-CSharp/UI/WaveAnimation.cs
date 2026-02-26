using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	public class WaveAnimation : MonoBehaviour
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x5C55", Offset = "0x5C55", VA = "0x5C55")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_WaveAnimation__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  float fVar4;
		  float fVar5;
		  undefined8 local_18;
		  float local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  fVar2 = *(float *)(param1 + 0x1c);
		  fVar3 = *(float *)(param1 + 0x20);
		  fVar4 = *(float *)(param1 + 0x18);
		  fVar1 = UnityEngine_SystemClock___cctor(0);
		  fVar5 = *(float *)(param1 + 0x14);
		  local_10 = fVar3 + 0.0;
		  local_c = (float4)(fVar4 + 0.0);
		  local_4 = (float4)local_10;
		  fVar1 = unnamed_function_9265(fVar1 * *(float *)(param1 + 0x10));
		  local_8 = (float4)(fVar2 + fVar5 * fVar1);
		  local_18 = CONCAT44(local_8,local_c);
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(param1_00,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x5C56", Offset = "0x5C56", VA = "0x5C56")]
		private void Update()
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x5C57", Offset = "0x5C57", VA = "0x5C57")]
		public WaveAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void UI_WaveAnimation___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Wiki_WikiUriRouter_HandleClickEvent__);
		    DAT_ram_00a5b8a2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_UI_Wiki_WikiUriRouter_HandleClickEvent__,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _speed;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _amount;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 _initPosition;
	}
}
