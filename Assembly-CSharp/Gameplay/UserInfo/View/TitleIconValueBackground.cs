using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	public class TitleIconValueBackground : MonoBehaviour
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x00005658 File Offset: 0x00003858
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000431")]
		public bool Enabled
		{
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x69BF", Offset = "0x69BF", VA = "0x69BF")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x19D5", Offset = "0x19D5", VA = "0x19D5")]
			set
			{
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x69C0", Offset = "0x69C0", VA = "0x69C0")]
		private void HandleEnabledChanged()
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00005670 File Offset: 0x00003870
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000432")]
		public int Index
		{
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x69C1", Offset = "0x69C1", VA = "0x69C1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x1C69", Offset = "0x1C69", VA = "0x1C69")]
			set
			{
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x1C6B", Offset = "0x1C6B", VA = "0x1C6B")]
		public void SetTitle(string value)
		{
		/* --- GHIDRA: SetTitle ---
		undefined4 Gameplay_UserInfo_View_TitleIconValueBackground__SetTitle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x14),0x35,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x1C6D", Offset = "0x1C6D", VA = "0x1C6D")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x69C2", Offset = "0x69C2", VA = "0x69C2", Slot = "4")]
		public virtual void SetValue(long value)
		{
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x69C3", Offset = "0x69C3", VA = "0x69C3", Slot = "5")]
		public virtual void SetTextValue(string value)
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x69C4", Offset = "0x69C4", VA = "0x69C4")]
		public TitleIconValueBackground()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_TitleIconValueBackground___ctor
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (param2 - 1 < 100) {
		    if (param2 == 1) {
		      func_ii_7050(*(undefined4 *)(param1 + 0x38),*(undefined4 *)(param1 + 0x3c),0);
		    }
		    else if (param2 < 0xb) {
		      func_ii_7050(*(undefined4 *)(param1 + 0x38),*(undefined4 *)(param1 + 0x40),0);
		    }
		    else {
		      func_ii_7050(*(undefined4 *)(param1 + 0x38),*(undefined4 *)(param1 + 0x44),0);
		    }
		  }
		  else {
		    func_ii_7050(*(undefined4 *)(param1 + 0x38),0,0);
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(param2 - 1 < 100),0);
		  return;
		}
		*/

		}

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Sprite _backgundDark;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Sprite _backgundLight;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Image _backgroudImage;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected TextMeshProUGUI _titleField;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextMeshProUGUI _valueField;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _icon;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x28")]
		private int _index;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x2C")]
		private bool _enabled;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x30")]
		protected long _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Enabled ---
		void Gameplay_UserInfo_View_TitleIconValueBackground__get_Enabled(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x2c),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Enabled ---
		int * Gameplay_UserInfo_View_TitleIconValueBackground__set_Enabled(int *param1)
		
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


		/* --- GHIDRA: get_Index ---
		void Gameplay_UserInfo_View_TitleIconValueBackground__get_Index
		               (int *param1,longlong param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a598ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a598ea = '\x01';
		  }
		  *(longlong *)(param1 + 0xc) = param2;
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar1 = UI_SimpleIconValue__set_IconAssetId((double)param2,StringLiteral_28780,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		            (param1,uVar1,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/


		/* --- GHIDRA: set_Index ---
		undefined4 Gameplay_UserInfo_View_TitleIconValueBackground__set_Index(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x18),0x13,0);
		  return uVar1;
		}
		*/

}
