using System;
using System.Collections;
using System.Runtime.InteropServices;
using Core.Data.User;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.World.View.Fx
{
	// Token: 0x0200035E RID: 862
	[Token(Token = "0x200035E")]
	public abstract class SnowFxControllerBase : MonoBehaviour
	{
		// Token: 0x060013AC RID: 5036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x659C", Offset = "0x659C", VA = "0x659C")]
		private void Start()
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x659D", Offset = "0x659D", VA = "0x659D")]
		private void OnDestroy()
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x659E", Offset = "0x659E", VA = "0x659E")]
		private void StartSnowAnimation(bool windy)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x659F", Offset = "0x659F", VA = "0x659F")]
		private void StopSnowAnimation()
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x65A0", Offset = "0x65A0", VA = "0x65A0")]
		private void LongTapOnLongTapEvent([Optional] LongTap _)
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x65A1", Offset = "0x65A1", VA = "0x65A1")]
		private void ButtonClickHandler()
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x65A2", Offset = "0x65A2", VA = "0x65A2")]
		private IEnumerator TrackCameraPosition()
		{
			return null;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x65A3", Offset = "0x65A3", VA = "0x65A3")]
		private void LoadProps()
		{
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x65A4", Offset = "0x65A4", VA = "0x65A4")]
		private void SaveProps()
		{
		}

		// Token: 0x060013B5 RID: 5045
		[Token(Token = "0x60013B5")]
		protected abstract void ValidateEnable(bool enable);

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x65A5", Offset = "0x65A5", VA = "0x65A5")]
		protected SnowFxControllerBase()
		{
		}

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected SnowFxView _fxView;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Button _button;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected LongTap _longTap;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Camera _worldCamera;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		private const string FxName = "snow";

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _fxEnabled;

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _windy;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _wasReset;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		private bool _longTapped;

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private IUserSettings _userSettings;

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine _trackCameraRoutine;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 _cameraPosition;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LocalProps _fxLocalProps;
	}
}
