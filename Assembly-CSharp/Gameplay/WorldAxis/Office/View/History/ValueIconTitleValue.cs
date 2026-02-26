using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	public class ValueIconTitleValue : MonoBehaviour
	{
		// Token: 0x0600124F RID: 4687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x6449", Offset = "0x6449", VA = "0x6449")]
		public void SetTitle(string title)
		{
		/* --- GHIDRA: SetTitle ---
		void Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue__SetTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x1c),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x644A", Offset = "0x644A", VA = "0x644A")]
		public void SetIcon(string iconAssetId)
		{
		/* --- GHIDRA: SetIcon ---
		void Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue__SetIcon
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  float4 local_8;
		  float4 local_10;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  longlong local_28;
		  longlong local_20;
		  uint local_14;
		  
		  piVar2 = *(int **)(param1 + 0x10);
		  local_28 = param3;
		  local_20 = param2;
		  if (param2 == 0) {
		    _local_8 = 0x3f8000003f800000;
		    local_30 = 0x3f8000003f800000;
		    _local_10 = 0x3f8000003f800000;
		    local_38 = 0x3f8000003f800000;
		    UnityEngine_Color32___ctor(&local_14,&local_38,0);
		    uVar5 = local_14;
		  }
		  else {
		    uVar5 = 0xff7a7aff;
		    if (0 < param2) {
		      uVar5 = 0xff4ecb49;
		    }
		  }
		  _local_8 = CONCAT44((float)(uVar5 >> 0x18) / 255.0,(float)(uVar5 >> 0x10 & 0xff) / 255.0);
		  _local_10 = CONCAT44((float)(uVar5 >> 8 & 0xff) / 255.0,(float)(uVar5 & 0xff) / 255.0);
		  iVar3 = *piVar2;
		  local_40 = _local_8;
		  local_48 = _local_10;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x178) * 4))
		            (piVar2,&local_48,*(undefined4 *)(iVar3 + 0x17c));
		  piVar2 = *(int **)(param1 + 0x14);
		  if (param3 == 0) {
		    _local_8 = 0x3f8000003f800000;
		    local_50 = 0x3f8000003f800000;
		    _local_10 = 0x3f8000003f800000;
		    local_58 = 0x3f8000003f800000;
		    UnityEngine_Color32___ctor(&local_14,&local_58,0);
		  }
		  else {
		    local_14 = 0xff7a7aff;
		    if (0 < param3) {
		      local_14 = 0xff4ecb49;
		    }
		  }
		  _local_8 = CONCAT44((float)(local_14 >> 0x18) / 255.0,(float)(local_14 >> 0x10 & 0xff) / 255.0);
		  _local_10 = CONCAT44((float)(local_14 >> 8 & 0xff) / 255.0,(float)(local_14 & 0xff) / 255.0);
		  iVar3 = *piVar2;
		  local_60 = _local_8;
		  local_68 = _local_10;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x178) * 4))
		            (piVar2,&local_68,*(undefined4 *)(iVar3 + 0x17c));
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = UnityEngine_GameObject__SetActive(&local_20,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar1,0);
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = UnityEngine_GameObject__SetActive(&local_28,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x644B", Offset = "0x644B", VA = "0x644B")]
		public void UpdateValues(long value1, long value2)
		{
		/* --- GHIDRA: UpdateValues ---
		void Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue__UpdateValues
		               (undefined4 *param1,undefined4 param2,longlong param3,undefined4 param4)
		
		{
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (param3 == 0) {
		    local_c = 0x3f8000003f800000;
		    local_20 = 0x3f8000003f800000;
		    local_14 = 0x3f8000003f800000;
		    local_28 = 0x3f8000003f800000;
		    UnityEngine_Color32___ctor(&local_4,&local_28,0);
		    *param1 = local_4;
		  }
		  else if (param3 < 1) {
		    *param1 = 0xff7a7aff;
		  }
		  else {
		    *param1 = 0xff4ecb49;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x644C", Offset = "0x644C", VA = "0x644C")]
		private Color32 ColorByValue(long value)
		{
		/* --- GHIDRA: ColorByValue ---
		void Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue__ColorByValue
		               (int param1,undefined4 param2,undefined8 param3,undefined8 param4,undefined4 param5)
		
		{
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x18),param2,0);
		  Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue__SetIcon(param1,param3,param4,param1);
		  return;
		}
		*/

			return default(Color32);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x644D", Offset = "0x644D", VA = "0x644D")]
		public void Init(string title, long value1, long value2)
		{
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x644E", Offset = "0x644E", VA = "0x644E")]
		public ValueIconTitleValue()
		{
		}

		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _value1;

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _value2;

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _icon;
	}
}
