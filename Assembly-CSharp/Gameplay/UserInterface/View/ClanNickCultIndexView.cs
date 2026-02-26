using System;
using AssetContent.Loaders;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	public class ClanNickCultIndexView : MonoBehaviour
	{
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BC")]
		public string Nick
		{
			[Token(Token = "0x600166A")]
			[Address(RVA = "0x682B", Offset = "0x682B", VA = "0x682B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600166B")]
			[Address(RVA = "0x682C", Offset = "0x682C", VA = "0x682C")]
			set
			{
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BD")]
		public ClanCultDic ClanCultDic
		{
			[Token(Token = "0x600166C")]
			[Address(RVA = "0x682D", Offset = "0x682D", VA = "0x682D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600166D")]
			[Address(RVA = "0x682E", Offset = "0x682E", VA = "0x682E")]
			set
			{
			}
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x682F", Offset = "0x682F", VA = "0x682F")]
		private void HandleNickChanged()
		{
		/* --- GHIDRA: HandleNickChanged ---
		void Gameplay_UserInterface_View_ClanNickCultIndexView__HandleNickChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5825b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a5825b = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Core_Extensions_Dict_ClanCultDicExt__GetClanCultBgAssetId
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Core_Extensions_Dict_ClanCultDicExt__GetDecorDotForBannerAssetId
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar2,uVar1,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x6830", Offset = "0x6830", VA = "0x6830")]
		private void HandleClanCultChanged()
		{
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x6831", Offset = "0x6831", VA = "0x6831")]
		public ClanNickCultIndexView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_View_ClanNickCultIndexView___ctor
		               (int param1,float param2,undefined4 param3)
		
		{
		  UnityEngine_UI_Image__get_fillAmount(*(undefined4 *)(param1 + 0x1c),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CultView2 _clanCultView;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _titleBackgound;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x1C")]
		private string _nick;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x20")]
		private ClanCultDic _clanCultDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Nick ---
		void Gameplay_UserInterface_View_ClanNickCultIndexView__get_Nick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x1c),param2,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x1c) = param2;
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x10),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_ClanCultDic ---
		void Gameplay_UserInterface_View_ClanNickCultIndexView__get_ClanCultDic
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (param2 != *(int *)(param1 + 0x20)) {
		    *(int *)(param1 + 0x20) = param2;
		    if (DAT_ram_00a5825b == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                );
		      DAT_ram_00a5825b = '\x01';
		      param2 = *(int *)(param1 + 0x20);
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = Core_Extensions_Dict_ClanCultDicExt__GetClanCultBgAssetId(param2,0);
		    Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = Core_Extensions_Dict_ClanCultDicExt__GetDecorDotForBannerAssetId
		                      (*(undefined4 *)(param1 + 0x20),0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (uVar2,uVar1,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ClanCultDic ---
		void Gameplay_UserInterface_View_ClanNickCultIndexView__set_ClanCultDic
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  return;
		}
		*/

}
