using System;
using AssetContent;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D53 RID: 3411
	[Token(Token = "0x2000D53")]
	public class AprViewSmall : AbstractDataRenderer<AprDicWrapper>, IAprView, IToolTipDataProvider
	{
		// Token: 0x060053A5 RID: 21413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053A5")]
		[Address(RVA = "0xA164", Offset = "0xA164", VA = "0xA164", Slot = "22")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Aprs_View_AprViewSmall__GetData(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5940c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a5940c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param1_00 = param1[9];
		  if (iVar1 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    param2_00 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(iVar1 + 0x10),0);
		  }
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A6")]
		[Address(RVA = "0xA165", Offset = "0xA165", VA = "0xA165", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Aprs_View_AprViewSmall__HandleDataChanged(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5940d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprDicWrapper___ctor__);
		    DAT_ram_00a5940d = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_AprDicWrapper___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A7")]
		[Address(RVA = "0xA166", Offset = "0xA166", VA = "0xA166")]
		public AprViewSmall()
		{
		}

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameAssetViewRawImage _gameAssetView;
	}
}
