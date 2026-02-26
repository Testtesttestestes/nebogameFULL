using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x0200054E RID: 1358
	[Token(Token = "0x200054E")]
	public class ResourceBarIconValueView : MonoBehaviour
	{
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005F2")]
		public GameRawImage Icon
		{
			[Token(Token = "0x6002095")]
			[Address(RVA = "0x71FA", Offset = "0x71FA", VA = "0x71FA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F3")]
		public string IconAssetId
		{
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x71FB", Offset = "0x71FB", VA = "0x71FB")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x71FC", Offset = "0x71FC", VA = "0x71FC")]
			set
			{
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F4")]
		public string Value
		{
			[Token(Token = "0x6002098")]
			[Address(RVA = "0x71FD", Offset = "0x71FD", VA = "0x71FD")]
			set
			{
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x170005F5")]
		public Color TextColor
		{
			[Token(Token = "0x6002099")]
			[Address(RVA = "0x71FE", Offset = "0x71FE", VA = "0x71FE")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x170005F6")]
		public bool ShowCloud
		{
			[Token(Token = "0x600209A")]
			[Address(RVA = "0x71FF", Offset = "0x71FF", VA = "0x71FF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x7200", Offset = "0x7200", VA = "0x7200")]
		public void SetTextColor(Color color, bool showCloud)
		{
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x7201", Offset = "0x7201", VA = "0x7201")]
		public ResourceBarIconValueView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ResourceBar_View_ResourceBarIconValueView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58326 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    DAT_ram_00a58326 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_Resources__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Resources__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected TextMeshProUGUI _label;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private Color _textColor;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x28")]
		private string _iconAssetId;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x2C")]
		private bool _showCloud;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IconAssetId ---
		void Gameplay_ResourceBar_View_ResourceBarIconValueView__get_IconAssetId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x28) = param2;
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_ShowCloud ---
		void Gameplay_ResourceBar_View_ResourceBarIconValueView__get_ShowCloud
		               (int param1,undefined8 *param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  *(undefined8 *)(param1 + 0x18) = *param2;
		  *(undefined8 *)(param1 + 0x20) = param2[1];
		  iVar1 = **(int **)(param1 + 0x14);
		  local_8 = param2[1];
		  local_10 = *param2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x14),&local_10,*(undefined4 *)(iVar1 + 0x17c));
		  *(undefined1 *)(param1 + 0x2c) = (undefined1)param3;
		  return;
		}
		*/

}
