using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	public class ContentToScrollableContent : MonoBehaviour
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x5BE0", Offset = "0x5BE0", VA = "0x5BE0")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_ContentToScrollableContent__Awake(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = UnityEngine_Transform__IsChildOf(param1[4],0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x5BE1", Offset = "0x5BE1", VA = "0x5BE1")]
		private void Update()
		{
		/* --- GHIDRA: Update ---
		void UI_ContentToScrollableContent__Update(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  uint param2_00;
		  undefined1 auStack_10 [12];
		  float4 local_4;
		  
		  if ((*(uint *)(param1 + 0x1c) & 0x7fffffff) < 0x7f800001) {
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties
		              (auStack_10,*(undefined4 *)(param1 + 0x10),0);
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		    param2_00 = (uint)(*(float *)(param1 + 0x1c) <= (float)local_4);
		    if (param2_00 == 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		      uVar1 = UnityEngine_UI_Selectable__set_interactable(uVar1,0);
		    }
		    else {
		      uVar1 = *(undefined4 *)(param1 + 0x18);
		    }
		    UnityEngine_Transform__GetParent(param1_00,uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x14),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x5BE2", Offset = "0x5BE2", VA = "0x5BE2", Slot = "4")]
		protected virtual void ValidateVisibleScroll()
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x5BE3", Offset = "0x5BE3", VA = "0x5BE3")]
		public ContentToScrollableContent()
		{
		}

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _scrollView;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _scrollViewContent;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _maxHeight;
	}
}
